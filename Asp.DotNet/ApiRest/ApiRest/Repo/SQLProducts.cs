using System;
using ApiRest.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ApiRest.Repo
{
    public class SqlProducts : IMemoryProduct
    {
        //#2
        private readonly string _connectionString;
        public SqlProducts(DataAccess connectionString)
        {
            _connectionString = connectionString.ConnectionStringSql;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        //Reemplazar los void por task, en los métodos y agregar async detrás
        public async Task CreateProduct(Product p)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.WriteProducts";
                comm.CommandType = CommandType.StoredProcedure;
                
                comm.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.Name;
                comm.Parameters.Add("@description", SqlDbType.VarChar, 200).Value = p.Description;
                comm.Parameters.Add("@price", SqlDbType.Float).Value = p.Price;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = p.Sku;
                await comm.ExecuteNonQueryAsync(); //No queries
                await Task.CompletedTask;
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el producto" + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public async Task DeleteProduct(string code)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;

            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.DeleteProducts";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = code;
                await comm.ExecuteNonQueryAsync(); //No queries, el await va en la instrucción final, el sp tiene su ENQAsync
                //No devuelve valor al finalizar la tarea
                await Task.CompletedTask;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el producto" + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public async Task<IEnumerable<Product>> GetAll() //Igual que en GetById
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;

            List<Product> products = new List<Product>(); //Initialize the list
            Product p;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.GetProducts";
                comm.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = await comm.ExecuteReaderAsync(); //Read queries

                
                while (reader.Read())
                {
                    p = new Product
                    {
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal)Convert.ToDouble(reader["Price"].ToString()),
                        Sku = reader["SKU"].ToString(),
                    };
                    products.Add(p); //Add to list
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el producto" + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            return products;
        }

        public async Task<Product> GetById(string code) //Agregar Task<MODEL>
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;
            
            Product p = null;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.GetProducts";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = code;
                SqlDataReader reader = await comm.ExecuteReaderAsync(); //Read queries, async await
                
                if (reader.Read())
                {
                    p = new Product
                    {
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal) Convert.ToDouble(reader["Price"].ToString()),
                        Sku = reader["SKU"].ToString(),
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el producto" + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            return p;
        }

        public async Task ModifyProduct(Product p)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.ModifyProducts";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.Name;
                comm.Parameters.Add("@description", SqlDbType.VarChar, 200).Value = p.Description;
                comm.Parameters.Add("@price", SqlDbType.Float).Value = p.Price;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = p.Sku;
                await comm.ExecuteNonQueryAsync(); //No queries
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar el producto" + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            await Task.CompletedTask; //No devuelve valor al finalizar la tarea
        }
    }
}
