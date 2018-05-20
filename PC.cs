using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class PC : Database
    {
        public int id, cost, id1, id2, id3, id4, id5, id6, id7, id8;
        public string name;

        public PC()
        {

        }
        public PC(int id, string name, int cost, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.id1 = id1;
            this.id2 = id2;
            this.id3 = id3;
            this.id4 = id4;
            this.id5 = id5;
            this.id6 = id6;
            this.id7 = id7;
            this.id8 = id8;
        }

        internal PB PB
        {
            get => default(PB);
            set
            {
            }
        }

        internal HDD HDD
        {
            get => default(HDD);
            set
            {
            }
        }

        internal CC CC
        {
            get => default(CC);
            set
            {
            }
        }

        internal GPU GPU
        {
            get => default(GPU);
            set
            {
            }
        }

        internal CPU CPU
        {
            get => default(CPU);
            set
            {
            }
        }

        internal MB MB
        {
            get => default(MB);
            set
            {
            }
        }

        internal CS CS
        {
            get => default(CS);
            set
            {
            }
        }

        internal RAM RAM
        {
            get => default(RAM);
            set
            {
            }
        }

        public void insertPC(string name, int cost, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8)
        {
            command.CommandText = "INSERT INTO pc (name, cost, id1, id2, id3, id4, id5, id6, id7, id8) VALUES('" + name + "','" + cost + "','" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "')";
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

        public List<PC> selectPC()
        {
            List<PC> pc = new List<PC>();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM pc";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pc.Add(new PC(Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]), Convert.ToInt32(reader["cost"]),
                            Convert.ToInt32(reader["id1"]), Convert.ToInt32(reader["id2"]),
                            Convert.ToInt32(reader["id3"]), Convert.ToInt32(reader["id4"]),
                            Convert.ToInt32(reader["id5"]), Convert.ToInt32(reader["id6"]),
                            Convert.ToInt32(reader["id6"]), Convert.ToInt32(reader["id8"])));
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
            return pc;
        }

    }
}
