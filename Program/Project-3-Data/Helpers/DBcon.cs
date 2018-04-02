using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_3
{
    class DBcon 
    {
        //database stuff
        private const String SERVER = "195.238.74.89";
        private const String DATABASE = "sinain1q_Project3";
        private const String UID = "sinain1q_test";
        private const String PASSWORD = "007123qwe";
        public static MySqlConnection dbConn;


        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);


            Application.ApplicationExit += (sender, args) => 
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };

        }

     }

}
