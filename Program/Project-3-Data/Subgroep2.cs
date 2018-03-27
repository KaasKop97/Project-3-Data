using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_3.Helpers;

namespace Project_3
{
    public partial class Subgroep2 : Form
    {
        public Subgroep2()
        {
            InitializeComponent();
            DBcon.InitializeDB();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart();
        }

        public void chart()
        {
            String query = "SELECT Country_Population FROM Population; SELECT Avg_Active_Users FROM Active_Users";
            //String query1 = "SELECT Avg_Active_Users FROM Active_Users";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                // String Country_name = reader["Country_name"].ToString();
                //String Country_population = reader["Country_population"].ToString();
                //String Avg_Active_Users = reader["Avg_Active_Users"].ToString();

                chart1.Series["Country Population"].Points.Add(reader.GetInt32("Country_population"));
                chart1.Series["Active Gamers"].Points.Add(reader.GetInt32("Avg_Active_gamers"));


            }

            reader.Close();

            DBcon.dbConn.Close();



        }
    }
}
