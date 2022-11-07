using System;
using ApiRest.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ApiRest.Repo
{
    public class SqlProducts : IMemoryProduct
    {
        private readonly string _connectionString;
        public SqlProducts(DataAccess connectionString)
        {
            _connectionString = connectionString.ConnectionStringSql;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        public void CreateProduct(Product p)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.CreateProducts";
                comm.CommandType = CommandType.StoredProcedure;
                
                comm.Parameters.Add("@name", SqlDbType.VarChar, 250).Value = p.Name;
                comm.Parameters.Add("@description", SqlDbType.VarChar, 500).Value = p.Description;
                comm.Parameters.Add("@price", SqlDbType.Float).Value = p.Price;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 250).Value = p.Sku;
                comm.ExecuteNonQuery(); //No queries
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear el producto " + e.ToString());
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public void DeleteProduct(string code)
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
                comm.ExecuteNonQuery(); //No queries
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

        public IEnumerable<Product> GetAll()
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;

            List<Product> products = new (); //Initialize the list
            Product p;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.GetProducts";
                comm.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = comm.ExecuteReader(); //Read queries

                
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

        public Product GetById(string code)
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
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 500).Value = code;
                SqlDataReader reader = comm.ExecuteReader(); //Read queries
                
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
                throw new Exception("Error al obtener el producto " + e);
            }
            finally
            {
                comm?.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            return p;
        }

        public void UpdateProduct(Product p)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand comm = null;
            try
            {
                sqlConnection.Open();
                comm = sqlConnection.CreateCommand();
                comm.CommandText = "dbo.UpdateProducts";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.Name;
                comm.Parameters.Add("@description", SqlDbType.VarChar, 200).Value = p.Description;
                comm.Parameters.Add("@price", SqlDbType.Float).Value = p.Price;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = p.Sku;
                comm.ExecuteNonQuery(); //No queries
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
        }
    }
}
