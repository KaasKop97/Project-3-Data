﻿using System;
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
    public partial class FilterSub2 : Form
    {
        public FilterSub2()
        {
            InitializeComponent();
            DBcon.InitializeDB();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["land1"].Points.Clear();
            chart2.Series["land2"].Points.Clear();
            chart3.Series["land3"].Points.Clear();
            chart4.Series["land4"].Points.Clear();
            chart();
            chart11();
            chart12();
            chart13();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["land1"].Points.Clear();
            chart2.Series["land2"].Points.Clear();
            chart3.Series["land3"].Points.Clear();
            chart4.Series["land4"].Points.Clear();
            chart14();
            chart15();
            chart16();
            chart17();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series["land1"].Points.Clear();
            chart2.Series["land2"].Points.Clear();
            chart3.Series["land3"].Points.Clear();
            chart4.Series["land4"].Points.Clear();
            chart18();
            chart19();
            chart20();
            chart21();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["land1"].Points.Clear();
            chart2.Series["land2"].Points.Clear();
            chart3.Series["land3"].Points.Clear();
            chart4.Series["land4"].Points.Clear();
            chart22();
            chart23();
            chart24();
            chart25();
        }

        public void chart()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='China'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY("China", reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart11()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Brazil'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart12()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='United States'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart13()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Russia'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart14()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Romania'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart15()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Mexico'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart16()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Malaysia'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart17()
        {
            String query = "SELECT * FROM Active_Users WHERE Country_Name='Netherlands'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY("Active Gamers", reader.GetString("Avg_Active_Users"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart18()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Russia'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["land1"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart19()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Ukraine'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart2.Series["land2"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart20()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Japan'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart3.Series["land3"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart21()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Canada'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart4.Series["land4"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart22()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Philippines'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart1.Series["land1"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart1.Series["land1"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        public void chart23()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Mexico'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart2.Series["land2"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart2.Series["land2"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }
        public void chart24()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Spain'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart3.Series["land3"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart3.Series["land3"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }
        public void chart25()
        {
            String query = "SELECT * FROM Active_users1 WHERE Country_Name='Poland'";


            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);


            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                //Console.WriteLine(reader.GetString("Population"));
                chart4.Series["land4"].Points.AddXY(reader.GetString("Country_name"), reader.GetString("Total_Play_Time2weeks"));
                chart4.Series["land4"].Points.AddXY("Avg Play Time2weeks", reader.GetString("Avg_Play_Time2weeks"));



            }


            reader.Close();

            DBcon.dbConn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
