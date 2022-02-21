using Npgsql;
using System.Data;
using Data;

namespace Infra
{
    public class UserDAO : ConnectionDB
    {
        public bool DoLogin(string user, string pass)
        {
            var sqlQuery = $@"select * from users.users";

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sqlQuery;
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        NpgsqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                User.Id = reader.GetInt32(0);
                                User.FirstName = reader?.GetString(1) ?? string.Empty;
                                User.LastName = reader?.GetString(2) ?? string.Empty;
                                User.Email = reader?.GetString(3) ?? string.Empty;
                                User.PhoneNumber = reader?.GetString(4) ?? string.Empty;
                                User.Addres_Id = reader.GetInt32(5);
                                User.Username = reader?.GetString(6) ?? string.Empty;
                                User.Password = reader?.GetString(7) ?? string.Empty;
                                User.Privilege = reader.GetInt32(8);
                                User.Status = reader.GetBoolean(9);
                                User.Register_date = reader.GetDateTime(10);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
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
