using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakePC
{
    class CS : Database
    {
        public int id, p9;
        public string p1, p2, p3, p4, p5, p6, p7, p8;

        public CS()
        {

        }
        public CS(int id, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, int p9)
        {
            this.id = id;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
            this.p8 = p8;
            this.p9 = p9;
        }

        public void insertCS(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, int p9)
        {
            command.CommandText = "INSERT INTO cs (p1, p2, p3, p4, p5, p6, p7, p8, p9) VALUES('" + p1 + "','" + p2 + "','" + p3 + "','" + p4 + "','" + p5 + "','" + p6 + "','" + p7 + "','" + p8 + "','" + p9 + "')";
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

        public List<CS> selectCS()
        {
            List<CS> cs = new List<CS>();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM cs";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cs.Add(new CS(Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["p1"]), Convert.ToString(reader["p2"]),
                            Convert.ToString(reader["p3"]), Convert.ToString(reader["p4"]),
                            Convert.ToString(reader["p5"]), Convert.ToString(reader["p6"]),
                            Convert.ToString(reader["p7"]), Convert.ToString(reader["p8"]),
                            Convert.ToInt32(reader["p9"])));
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
            return cs;
        }

    }
}
