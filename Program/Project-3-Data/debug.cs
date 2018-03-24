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
        public debug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.ForeColor = Color.Red;
            DbHelper dbhelper = new DbHelper();
            DataTable datasource = dbhelper.SelectFromDb("SELECT * FROM " + textBox1.Text);
            if(datasource.Rows.Count == 0)
            {
                label1.Text = "ERROR: table does not exist.";
            }
            dataGridView1.DataSource = datasource;
        }
    }
}
