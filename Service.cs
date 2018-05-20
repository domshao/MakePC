using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class Service : Database
    {
        public int id, cost;
        public string name, description;

        public Service()
        {

        }
        public Service(int id, string name, int cost, string description)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.description = description;
        }

        public void insertService(string name, int cost, string description)
        {
            command.CommandText = "INSERT INTO service (name, cost, description) VALUES('" + name + "','" + cost + "','" + description + "')";
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

        public List<Service> selectService()
        {
            List<Service> service = new List<Service>();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM service";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    service.Add(new Service(Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]), Convert.ToInt32(reader["cost"]),
                            Convert.ToString(reader["description"])));
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
            return service;
        }
    }
}
