using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class Client : Database 
    {
        public int id;
        public string Fio;
        public string Telephone;
        public string Adres;
        public string Email;

        public Client()
        {

        }

        public Client(int id, string Fio, string Telephone, string Adres, string Email)
        {
            this.id = id;
            this.Fio = Fio;
            this.Telephone = Telephone;
            this.Adres = Adres;
            this.Email = Email;
        }

        public void insertClient(string Fio, string Telephone, string Adres, string Email)
        {
            command.CommandText = "INSERT INTO client(fio,telephone,adres,email) VALUES('" + Fio + "','" + Telephone + "','" + Adres + "','" + Email + "')";
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

        public List<Client> selectClient()
        {
            List<Client> client = new List<Client>();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM client;";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client.Add(new Client(Convert.ToInt32(reader["id"]), Convert.ToString(reader["fio"]),
                            Convert.ToString(reader["telephone"]), Convert.ToString(reader["adres"]),
                            Convert.ToString(reader["email"])));
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
            return client;
        }
    }
}
