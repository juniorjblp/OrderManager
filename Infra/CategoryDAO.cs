using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class CategoryDAO : ConnectionDB
    {
        private NpgsqlDataReader reader;
        public DataTable ListCategory()
        {
            var sqlQuery = @"SELECT idcat as Id,
                             category as CategoryName
                             FROM products.category order by id";
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

        public bool InsertCategory(string category)
        {
            var sqlQuery = String.Format(@"INSERT INTO products.category 
                                            (category) 
                                           VALUES ('{0}')",
                                                   category);

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
                        command.Parameters.AddWithValue("@category", category);
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

        public bool DeleteCategory(int id)
        {
            var sqlQuery = String.Format("DELETE FROM products.category WHERE idcat = '{0}'", id);

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
                        command.Parameters.AddWithValue("@idcat", id);
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

        public bool UpdateCategory(int id, string category)
        {
            var sqlQuery = String.Format(@"UPDATE products.category SET 
                                            category = '{1}'
                                            WHERE idcat = {0}",
                                            id,
                                            category);

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
                        command.Parameters.AddWithValue("@category", category);

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
