using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_3.Helpers;

namespace Project_3
{
    public partial class debug : Form
    {
        private DataTable medianIncomeTable;
        private DataTable onlineSalesPercentage;
        private DbHelper dbHelp = new DbHelper();
        public debug()
        {
            InitializeComponent();
            medianIncomeTable = dbHelp.SelectFromDb("SELECT * FROM Co_modaal_inkomen");
            onlineSalesPercentage = dbHelp.SelectFromDb("SELECT * FROM Co_online_kopen_percentage");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.ForeColor = Color.Red;
            //Console.WriteLine(dataFromDb.Columns);
            //foreach (DataColumn dcc in dataFromDb.Columns)
            //{
            //    Console.WriteLine(dcc.ToString());
            //}
            //var datasource = dataFromDb.Select("y2010 = land_naam = 'Austria' AND land_naam = land_naam1");
            //foreach (DataRow dr in datasource)
            //{
            //    Console.WriteLine(dr["land_naam"]);
            //}
            //DataTable datasource = dbhelper.SelectFromDb(textBox1.Text);
            //if(datasource.Rows.Count == 0)
            //{
            //   label1.Text = "ERROR: Somethings wrong.";
            //}
            //dataGridView1.DataSource = datasource;
        }
    }
}
