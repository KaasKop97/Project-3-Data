using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_3.Subgroep2
{
    public partial class Sub2totpldtm : Form
    {
        public Sub2totpldtm()
        {
            InitializeComponent();
            DBcon.InitializeDB();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["World Wide Play time 2 weeks"].Points.Clear();
            chart1.Series["Avg Play time 2 weeks"].Points.Clear();
            chart();

        }

        public void chart()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Brazil' or Country_Name='China' or Country_Name='Indonesia' or Country_Name='Russia' or Country_Name='United States'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["World Wide Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["Avg Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart2()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Mexico' or Country_Name='Japan' or Country_Name='Philippines' or Country_Name='Turkey' or Country_Name='Thailand'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["World Wide Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["Avg Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart3()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='France' or Country_Name='Germany' or Country_Name='Italy' or Country_Name='South Korea' or Country_Name='United Kingdom'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["World Wide Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["Avg Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }
        public void chart4()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Spain' or Country_Name='Ukraine' or Country_Name='Poland' or Country_Name='Argentina' or Country_Name='Canada'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["World Wide Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["Avg Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart5()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Sweden' or Country_Name='Romania' or Country_Name='Netherlands' or Country_Name='Australia' or Country_Name='malaysia'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["World Wide Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["Avg Play time 2 weeks"].Points.AddXY(reader.GetString("Country_Name"), reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["World Wide Play time 2 weeks"].Points.Clear();
            chart1.Series["Avg Play time 2 weeks"].Points.Clear();
            chart2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series["World Wide Play time 2 weeks"].Points.Clear();
            chart1.Series["Avg Play time 2 weeks"].Points.Clear();
            chart3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["World Wide Play time 2 weeks"].Points.Clear();
            chart1.Series["Avg Play time 2 weeks"].Points.Clear();
            chart4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["World Wide Play time 2 weeks"].Points.Clear();
            chart1.Series["Avg Play time 2 weeks"].Points.Clear();
            chart5();
        }
    }
}
