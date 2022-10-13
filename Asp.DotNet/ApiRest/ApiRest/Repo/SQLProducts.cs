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
                comm.CommandText = "dbo.WriteProducts";
                comm.CommandType = CommandType.StoredProcedure;
                
                comm.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = p.Name;
                comm.Parameters.Add("@description", SqlDbType.VarChar, 200).Value = p.Description;
                comm.Parameters.Add("@price", SqlDbType.Float).Value = p.Price;
                comm.Parameters.Add("@sku", SqlDbType.VarChar, 50).Value = p.Sku;
                comm.ExecuteNonQuery();
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

        public void DeleteProduct(string code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(string code)
        {
            throw new NotImplementedException();
        }

        public void ModifyProduct(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
