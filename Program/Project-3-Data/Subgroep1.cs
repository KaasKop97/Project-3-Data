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
            FillDropDown();
        }

        public void FillChart(int year = 0)
        {
            //At first we show all the data we currently have.
            string yearForDb = "y" + year;
            string sqlCommand = "SELECT * FROM Co_modaal_inkomen, Co_online_kopen_percentage";
            if(year != 0)
            {
                sqlCommand = "SELECT mi.land_naam as ln, mi." + yearForDb + " as miy, ok." + yearForDb + " as oky FROM Co_modaal_inkomen as mi, Co_online_kopen_percentage as ok WHERE mi.land_naam = ok.land_naam";
            }

            var dataFromDb = dbHelp.SelectFromDb(sqlCommand);
            foreach(DataRow dr in dataFromDb.Rows)
            {
                chart1.Series["Online Purchases"].Points.AddXY(0, dr["oky"]);
                chart1.Series["Median Income"].Points.AddXY(0, dr["miy"]);
                Console.WriteLine(dr["oky"]);
                Console.WriteLine(dr["miy"]);
            }
        }

        public void FillDropDown()
        {
            var dataSource = new List<int>();

            IEnumerable<int> years = Enumerable.Range(2008, 10);
            foreach(int year in years)
            {
                dataSource.Add(year);
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
