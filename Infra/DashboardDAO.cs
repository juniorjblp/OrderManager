using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class DashboardDAO : ConnectionDB
    {
        private NpgsqlDataReader reader;
        public Int64 CustumersCount()
        {
            var sqlQuery = String.Format("SELECT COUNT(*) FROM entities.person");

            Int64 count;

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
                        count = (Int64)command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return count;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public Int64 ProductsCount()
        {
            var sqlQuery = String.Format("SELECT COUNT(*) FROM products.product");

            Int64 count;

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
                        count = (Int64)command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return count;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public Int64 OdersCount()
        {
            var sqlQuery = String.Format("SELECT COUNT(*) FROM orders.orders");

            Int64 count;

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
                        count = (Int64)command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
                return count;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public string OderValueCount()
        {
            var sqlQuery = String.Format("SELECT SUM(value) FROM orders.orders");

            string count;

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
                        count = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", (decimal)command.ExecuteScalar());
                        command.Parameters.Clear();
                    }
                }
                return count;
            }
            catch (NpgsqlException)
            {
                throw;
            }
        }

        public DataTable LowStockProductsCount()
        {
            var sqlQuery = @"SELECT id, name, quantity FROM products.product where quantity < 10 order by id;";
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
    }
}
