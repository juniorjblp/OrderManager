using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class OrderDAO : ConnectionDB
    {
        private NpgsqlDataReader reader;
        public DataTable ListOrders()
        {
            var sqlQuery = @"SELECT orders.id as Id, 
                                    customer_id as CustomerId, 
                                    firstname as CustomerFirstName, 
                                    lastname as CustomerLastName,
                                    cpf as CustomerCpf,
                                    create_date as CreateDate, 
                                    value as Value, 
                                    order_status.status as Status 
                            FROM orders.orders 
                            LEFT JOIN entities.person ON customer_id = person.id
                            LEFT JOIN orders.order_status ON orders.status = order_status.id;";
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

        public DataTable ListOrdersProducts(int orderid)
        {
            var sqlQuery = $@"select * from orders.orders as ord
                                join orders.order_product as orp on orp.order_id = ord.id 
                                join products.product as p on p.id = orp.product_id 
                                join products.category as c on c.idcat = p.category_id WHERE ord.id = {orderid} ORDER BY ord.id";
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

        public bool InsertOrder(int customerid, double value, int status)
        {
            var sqlQuery = String.Format(@"INSERT INTO orders.orders 
                                            (customer_id, 
                                             create_date, 
                                             value, 
                                             status) 
                                           VALUES ( {0}, 
                                                   NOW(), 
                                                    {1}, 
                                                    {2})",
                                                   customerid,
                                                   value,
                                                   status);

            var sqlQuery2 = $@"INSERT INTO orders.orders 
                                            (customer_id,
                                             create_date,
                                             value,
                                             status)
                                           VALUES( {customerid}, 
                                                   NOW(), 
                                                    {value}, 
                                                    {status})";

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
                        command.Parameters.AddWithValue("@customer_id", customerid);
                        command.Parameters.AddWithValue("@create_date", "NOW()");
                        command.Parameters.AddWithValue("@value", value);
                        command.Parameters.AddWithValue("@status", status);
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

        public bool InserProductOrder(int orderid, int productid)
        {
            var sqlQuery = String.Format(@"INSERT INTO orders.order_product (order_id,  product_id) 
                                           VALUES ( {0}, {1})", orderid, productid);

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
                        command.Parameters.AddWithValue("@order_id", orderid);
                        command.Parameters.AddWithValue("@product_id", productid);
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


        public bool DeleteOrder(int id)
        {
            var sqlQuery = String.Format("DELETE FROM orders.orders WHERE id = '{0}'", id);

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
    }
}
