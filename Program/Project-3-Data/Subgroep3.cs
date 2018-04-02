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

namespace Project_3
{
    public partial class Subgroep3 : Form
    {
        public Subgroep3()
        {
            InitializeComponent();
            DBcon.InitializeDB();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            conn();
            String query = "SELECT Genres.genre, count(Games.game) AS gamecount_genre FROM Genres_per_game INNER JOIN Genres ON(Genres.genre_id = Genres_per_game.genre_id) INNER JOIN Games ON(Games.game_id = Genres_per_game.game_id) WHERE Genres.genre_id = Genres_per_game.genre_id GROUP BY Genres.genre";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);
            DBcon.dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> ExceptionMessages = new Dictionary<string, int>();

            while (reader.Read())
            {
                ExceptionMessages.Add(reader.GetString("genre"),reader.GetInt32("gamecount_genre"));
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 5;
                
            }
            foreach (KeyValuePair<string, int> exception in ExceptionMessages)
                chart1.Series[0].Points.AddXY(exception.Key, exception.Value);

            reader.Close();
            DBcon.dbConn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            conn();
            String query = "Select nr_of_genres, count(game_id) as nr_of_games From(Select game_id, count(genre_id) as nr_of_genres from Genres_per_game group by game_id order by game_id) as nr_genres_per_game group by nr_of_genres order by nr_of_genres";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);
            DBcon.dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> ExceptionMessages = new Dictionary<string, int>();

            while (reader.Read())
            {
                ExceptionMessages.Add(reader.GetString("nr_of_genres"), reader.GetInt32("nr_of_games"));
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 2;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Number of genres";

            }
            foreach (KeyValuePair<string, int> exception in ExceptionMessages)
                chart1.Series[0].Points.AddXY(exception.Key, exception.Value);

            reader.Close();
            DBcon.dbConn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            conn();
            String query = "Select sum(Games.owners)/10000 as owners, sum(Genres.users)/10000 as total_users from Games, Genres";

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);
            DBcon.dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> ExceptionMessages = new Dictionary<string, int>();

            while (reader.Read())
            {
                //int total_users = reader.GetInt32("total_users");
                //int owners = reader.GetInt32("owners");
                ExceptionMessages.Add("Total users", reader.GetInt32("total_users"));
                ExceptionMessages.Add("Owners", reader.GetInt32("owners"));
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                
            }
            foreach (KeyValuePair<string, int> exception in ExceptionMessages)
                chart1.Series[0].Points.AddXY(exception.Key, exception.Value);

            reader.Close();
            DBcon.dbConn.Close();
        }

        public void conn()
        {
            String query = "SELECT Genres.genre, count(Games.game) AS gamecount_genre FROM Genres_per_game INNER JOIN Genres ON(Genres.genre_id = Genres_per_game.genre_id) INNER JOIN Games ON(Games.game_id = Genres_per_game.game_id) WHERE Genres.genre_id = Genres_per_game.genre_id GROUP BY Genres.genre";
            //select from table games;

            MySqlCommand cmd = new MySqlCommand(query, DBcon.dbConn);

            DBcon.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                //chart1.Series["Genre"].Points.Add(reader.GetString("Genre"));
                //chart1.Series["Game"].Points.Add(reader.GetString("Game"));

            }

            reader.Close();

            DBcon.dbConn.Close();
        }
    }
}
