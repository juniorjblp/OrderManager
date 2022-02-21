using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public abstract class ConnectionDB
    {
        private readonly string connectionString;

        public ConnectionDB()
        {
            connectionString =
                $@"Server=ec2-34-205-230-1.compute-1.amazonaws.com;
                  Username=ykxblslsawuzhu;
                  Database=d1uace20ohotn8;
                  Port=5432;
                  Password=f062791023033ee0b27193f9057c90d0789a6f75b4e0511c8b6a32b6491a946e;
                  SSLMode=Prefer";
        }

        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
