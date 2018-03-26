using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project_3.Helpers
{
    class DbHelper
    {
        private MySqlConnectionStringBuilder sqlConnBuilder = new MySqlConnectionStringBuilder();
        private MySqlConnection sqlConn;
        public DbHelper()
        {
            if (!ConnectToDb())
            {
                Console.WriteLine("Cannot open connection to the database server");
            }
        }

        public bool ConnectToDb()
        {
            sqlConnBuilder.Server = "inf1g.nl";
            sqlConnBuilder.Port = 3306;
            sqlConnBuilder.UserID = "test";
            sqlConnBuilder.Password = "test";
            sqlConnBuilder.Database = "project3";
            try
            {
                sqlConn = new MySqlConnection(sqlConnBuilder.ConnectionString);
                sqlConn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                HandleException(e);
                return false;
            }
        }

        public DataTable SelectFromDb(string query)
        {
            //Escaping characters and such..
            string cleanQuery = MySqlHelper.EscapeString(query);
            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cleanQuery, sqlConn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;
                sqlDataAdapter.Fill(dataTable);
            }
            catch (MySqlException e)
            {
                HandleException(e, query);
            }
            return dataTable;
        }

        //Everything that goes wrong with MySql will raise an MySqlException. Since this is also used in connectToDb() the query is optional.
        public void HandleException(MySqlException exception, string query = "")
        {
            Console.WriteLine("!!EXCEPTION THROWN: \n" + exception.ToString());
            if(query.Length != 0)
            {
                Console.WriteLine("Query executed: " + query);
            }
        }

        public void CloseConnection()
        {
            sqlConn.Close();
        }
    }
}
