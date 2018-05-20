using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class Order : Database
    {
        public int id;
        public string clientFio, orderDate, orderPath, cost;

        public Order()
        {

        }
        public Order(int id, string clientFio, string orderDate, string orderPath, string cost)
        {
            this.id = id;
            this.clientFio = clientFio;
            this.orderDate = orderDate;
            this.orderPath = orderPath;
            this.cost = cost;
        }

        internal Client Client
        {
            get => default(Client);
            set
            {
            }
        }

        public void insertOrder(string clientFio, string orderDate, string orderPath, string cost)
        {
            command.CommandText = "INSERT INTO orders (clientFio, orderDate, orderPath, cost) VALUES('" + clientFio + "','" + orderDate + "','" + orderPath + "','" + cost + "')";
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

        public List<Order> selectOrder()
        {
            List<Order> order = new List<Order>();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM orders";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    order.Add(new Order(Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["clientFio"]), Convert.ToString(reader["orderDate"]),
                            Convert.ToString(reader["orderPath"]), Convert.ToString(reader["cost"])));
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
            return order;
        }

        public int selectOrderCount()
        {
            int orderCount = 0;
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM orders";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orderCount = orderCount + 1;
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
            return orderCount;
        }
    }
}
