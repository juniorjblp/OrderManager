using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Infra
{
    public class CustomerDAO : ConnectionDB
    {
        private NpgsqlDataReader reader;
        public DataTable ListCustomers()
        {
            var sqlQuery = @"SELECT 
                            _id as Id, 
                            _firstname as FirstName, 
                            _lastname as LastName, 
                            _cpf as Cpf, 
                            _birthdate as BirthDate, 
                            _email as Email FROM entities.sl_person() order by _id";
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

        public bool InsertCustomer(string firstname, string lastname, string cpf, string birthdate, string email)
        {
            var sqlQuery = String.Format(@"INSERT INTO entities.person 
                                            (firstname, 
                                             lastname, 
                                             cpf, 
                                             birthdate, 
                                             email) 
                                           VALUES ('{0}', 
                                                   '{1}', 
                                                   '{2}', 
                                                   '{3}', 
                                                   '{4}')", 
                                                   firstname, 
                                                   lastname, 
                                                   cpf, 
                                                   birthdate, 
                                                   email);

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
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@birthdate", birthdate);
                        command.Parameters.AddWithValue("@email", email);
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

        public bool DeleteCustomer(int id)
        { 
            var sqlQuery = String.Format("DELETE FROM entities.person WHERE id = '{0}'", id);

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

        public bool UpdateCustomer(int id, string firstname, string lastname, string cpf, string birthdate, string email)
        {
            var sqlQuery = String.Format(@"UPDATE entities.person SET 
                                            firstname = '{1}', 
                                            lastname = '{2}', 
                                            cpf = '{3}',
                                            birthdate = '{4}',
                                            email = '{5}'
                                            WHERE id = {0}",
                                            id,
                                            firstname,
                                            lastname,
                                            cpf,
                                            birthdate,
                                            email);

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
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.AddWithValue("@cpf", cpf);
                        command.Parameters.AddWithValue("@birthdate", birthdate);
                        command.Parameters.AddWithValue("@email", email);
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
