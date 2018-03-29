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

        public void FillChart(string country = "", int year = 0)
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
                    chart1.Series["Online Purchases"].Points.AddXY(0, properValue);
                    chart1.Series["Online Purchases"].Label = properValue.ToString();
                    chart1.Series["Median Income"].Points.AddXY(0, dr["Modaal_Inkomen"]);
                    chart1.Series["Median Income"].Label = dr["Modaal_Inkomen"].ToString();
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
            var dataSourceCountries = new List<string>();

            IEnumerable<int> years = Enumerable.Range(2008, 10);
            foreach(int year in years)
            {
                dataSourceYears.Add(year);
            }
            comboBox2.DataSource = dataSourceYears;
            comboBox4.DataSource = dataSourceYears;

            var countriesFromDb = dbHelp.SelectFromDb("SELECT land_naam FROM Co_modaal_inkomen");
            foreach(DataRow country in countriesFromDb.Rows)
            {
                dataSourceCountries.Add(country["land_naam"].ToString());
            }
            comboBox1.DataSource = dataSourceCountries;
            comboBox3.DataSource = dataSourceCountries;
        }

        public void ClearChart()
        {
            chart1.Series["Online Purchases"].Points.Clear();
            chart1.Series["Median Income"].Points.Clear();
        }

        //Here we're going to handle when years are changed in the dropdown menu.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearChart();
            //FillChart(Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() != "" && comboBox2.SelectedIndex.ToString() != "")
            {
                ClearChart();
                Console.WriteLine(comboBox1.SelectedValue.ToString());
                FillChart(comboBox1.SelectedValue.ToString(), Convert.ToInt32(comboBox2.SelectedValue));
            }
        }
    }
}
