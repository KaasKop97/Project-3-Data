using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            FillDropDowns();
        }

        public void FillChart(string country, int year, System.Windows.Forms.DataVisualization.Charting.Chart chartName)
        {
            //At first we show all the data we currently have.
            string yearForDb = "y" + year;
            string sqlCommand = "SELECT * FROM Co_modaal_inkomen, Co_online_kopen_percentage";
            if (year != 0 && country.Length != 0)
            {
                sqlCommand = 
                    "SELECT mi.land_naam as Country_Name, mi." + yearForDb + " as Modaal_Inkomen, okp." + yearForDb + " as Online_Kopen " +
                    "FROM Co_modaal_inkomen as mi, Co_online_kopen_percentage as okp " +
                    "WHERE mi.land_naam = '" + country + "' AND mi.land_naam = okp.land_naam";
            }

            var dataFromDb = dbHelp.SelectFromDb(sqlCommand);
            foreach(DataRow dr in dataFromDb.Rows)
            {
                try
                {
                    var properValue = Convert.ToInt32(dr["Online_Kopen"]) * Convert.ToInt32(dr["Modaal_Inkomen"]) / 100;
                    chartName.Series["Online Purchases"].Points.AddXY(0, properValue);
                    chartName.Series["Online Purchases"].Label = properValue.ToString();
                    chartName.Series["Median Income"].Points.AddXY(0, dr["Modaal_Inkomen"]);
                    chartName.Series["Median Income"].Label = dr["Modaal_Inkomen"].ToString();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("!!!ERROR: " + e.ToString());
                    throw;
                }
                
            }
        }

        public void FillDropDowns()
        {
            var dataSourceYears = new List<int>();
            var dataSourceYears2 = new List<int>();
            var dataSourceCountries = new List<string>();
            var dataSourceCountries2 = new List<string>();

            IEnumerable<int> years = Enumerable.Range(2008, 10);
            foreach(int year in years)
            {
                dataSourceYears.Add(year);
                dataSourceYears2.Add(year);
            }
            comboBox2.DataSource = dataSourceYears;
            comboBox3.DataSource = dataSourceYears2;

            var countriesFromDb = dbHelp.SelectFromDb("SELECT land_naam FROM Co_modaal_inkomen");
            foreach(DataRow country in countriesFromDb.Rows)
            {
                dataSourceCountries.Add(country["land_naam"].ToString());
                dataSourceCountries2.Add(country["land_naam"].ToString());
            }
            comboBox1.DataSource = dataSourceCountries;
            comboBox4.DataSource = dataSourceCountries2;
        }

        public void ClearChart(System.Windows.Forms.DataVisualization.Charting.Chart chartName)
        {
            chartName.Series["Online Purchases"].Points.Clear();
            chartName.Series["Median Income"].Points.Clear();
        }

        //Here we're going to handle when years are changed in the dropdown menu.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() != "" && comboBox2.SelectedIndex.ToString() != "")
            {
                ClearChart(chart1);
                FillChart(comboBox1.SelectedValue.ToString(), Convert.ToInt32(comboBox2.SelectedValue), chart1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex.ToString() != "" && comboBox4.SelectedIndex.ToString() != "")
            {
                ClearChart(chart2);
                FillChart(comboBox4.SelectedValue.ToString(), Convert.ToInt32(comboBox3.SelectedValue), chart2);
            }
        }
    }
}
