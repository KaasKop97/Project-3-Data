using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project3
{
    public class User
    {
        
        
        // User class stuff
        public String Id { get; private set; }

        public String Username { get; private set; }

        public String Password { get; private set; }


        private User(String id, String u, String p)
        {
            Id = id;
            Username = u;
            Password = p;
        }


        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            String query = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String username = reader["username"].ToString();
                String password = reader["password"].ToString();

                User u = new User(id, username, password);

                users.Add(u);
            }

            reader.Close();

            DBcon.dbConn.Close();

            return users;
        }


        public static User Insert(String id, String u, String p)
        {
            String query = string.Format("INSERT INTO users(id, username, password) VALUES ('{0}', '{1}', '{2}')", id, u, p);

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            cmd.ExecuteNonQuery();
            //int id = (int)cmd.LastInsertedId;

            User user = new User(id, u, p);

            DBcon.dbConn.Close();

            return user;

        }
        public void Update(string u, string p)
        {
            String query = string.Format("UPDATE users SET username='{0}', password='{1}' WHERE ID={2}", u, p, Id);

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            cmd.ExecuteNonQuery();

            DBcon.dbConn.Close();
        }

        public void Delete()
        {
            String query = string.Format("DELETE FROM users WHERE ID={0}", Id);

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            cmd.ExecuteNonQuery();

            DBcon.dbConn.Close();
        }
    }
}
