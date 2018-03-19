using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Project3
{
    class Population
    {
        public String Country_name { get; private set; }
        public String Country_population { get; private set; }


        private Population(String Name, String Pop)
        {
            Country_name = Name;
            Country_population = Pop;

        }

        public static List<Population> GetPop()
        {
            List<Population> pops = new List<Population>();

            String query = "SELECT * FROM Population";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              
                String Country_name = reader["Country_name"].ToString();
                String Country_population = reader["Country_population"].ToString();

                Population p = new Population(Country_name, Country_population);

                pops.Add(p);
            }

            reader.Close();

            DBcon.dbConn.Close();

            return pops;
        }




    }
}
