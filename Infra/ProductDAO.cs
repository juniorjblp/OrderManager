using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class ProductDAO : ConnectionDB
    {
        private NpgsqlDataReader reader;
        public DataTable ListProduct()
        {
            var sqlQuery = @"SELECT id AS Id, 
                            name as Name, 
                            category_id AS Category_id, 
                            products.category.category AS Category, 
                            quantity AS Quantity, 
                            value AS Value 
                            FROM products.product
			                JOIN products.category on idcat  = category_id ORDER BY id";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        DataTable table = new DataTable();
                        command.Connection = connection;
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        table.Load(reader);
                        reader.Close();

                        return table;
                    }
                }
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public bool InsertProduct(string name, int category_id, int quantity, string value)
        {
            var sqlQuery = String.Format(@"INSERT INTO products.product 
                                            (name, 
                                             category_id, 
                                             quantity, 
                                             value) 
                                           VALUES ('{0}', 
                                                    {1}, 
                                                    {2}, 
                                                    {3})",
                                                   name,
                                                   category_id,
                                                   quantity,
                                                   value);

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@category_id", category_id);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@value", value);
                        command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return true;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public bool DeleteProduct(int id)
        {
            var sqlQuery = String.Format("DELETE FROM products.product WHERE id = '{0}'", id);

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return true;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public bool UpdateCustomer(int id, string name, int category_id, int quantity, string value)
        {
            var sqlQuery = String.Format(@"UPDATE products.product SET 
                                            name = '{1}', 
                                            category_id = '{2}', 
                                            quantity = '{3}',
                                            value = '{4}'
                                            WHERE id = {0}",
                                            id,
                                            name,
                                            category_id,
                                            quantity,
                                            value);

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@category_id", category_id);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@value", value);
                        command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return true;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }
    }
}
