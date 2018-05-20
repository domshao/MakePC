using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class User : Database
    {
        string login;
        string password;

        public User()
        {
            this.login = "";
            this.password = "";
        }

        public User (string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public void insertUser(string login, string password)
        {
            command.CommandText = "INSERT INTO users(login,password) VALUES('" + login + "','" + password + "')";
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                { }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
        }

        public int checkUser(string login, string password)
        {
            int id = -1;
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM users WHERE login='" + login + "' AND password = '" + password + "';";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["login"].ToString() == login && reader["password"].ToString() == password)
                        id = Convert.ToInt32(reader["id"]);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            return id;
        }

    }
}
