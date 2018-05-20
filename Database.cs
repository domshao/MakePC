using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class Database
    {
        private string connectionString = "datasource=localhost;username=root;password=;database=makepc";
        public MySqlCommand command = new MySqlCommand();
        public MySqlConnection connection;
        public Database()
        {
            connection = new MySqlConnection(connectionString);
            command.Connection = connection;
            command.Connection.Open();
        }
    }
}
