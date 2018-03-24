using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Project_3.Helpers;

namespace Project_3
{
    public partial class Subgroep1 : Form
    {
        private DbHelper dbHelp = new DbHelper();
        public Subgroep1()
        {
            InitializeComponent();
            FillDropDown();
            FillChart();
        }

        public void FillChart(int year = 0)
        {
            //At first we show all the data we currently have.
            string sqlCommand = "SELECT Online_Purchases, Median_Income FROM koelman";
            if(year != 0)
            {
                sqlCommand = "SELECT Online_Purchases, Median_Income FROM koelman WHERE Year = " + year.ToString();
            }

            var dataFromDb = dbHelp.SelectFromDb(sqlCommand);
            foreach(DataRow dr in dataFromDb.Rows)
            {
                chart1.Series["Online Purchases"].Points.AddXY(0, dr["Online_Purchases"]);
                chart1.Series["Median Income"].Points.AddXY(0, dr["Median_Income"]);
            }
        }

        public void FillDropDown()
        {
            var dataFromDb = dbHelp.SelectFromDb("SELECT Year FROM koelman ORDER BY Year DESC");
            var dataSource = new List<int>();
            
            foreach(DataRow dr in dataFromDb.Rows)
            {
                dataSource.Add(Convert.ToInt32(dr["Year"]));
            }
            dataSource.Add(0); //DEBUG for now, adding the 0 resets the charts to show all the years.
            comboBox1.DataSource = dataSource;
        }

        public void ClearChart()
        {
            chart1.Series["Online Purchases"].Points.Clear();
            chart1.Series["Median Income"].Points.Clear();
        }

        //Here we're going to handle when years are changed in the dropdown menu.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearChart();
            FillChart(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
