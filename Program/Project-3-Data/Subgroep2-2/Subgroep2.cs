using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_3.Helpers;

namespace Project_3.Subgroep2
{
    public partial class Subgroep2 : Form
    {
        public Subgroep2()
        {
            InitializeComponent();
            DBcon.InitializeDB();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Sub2activegamers act = new Sub2activegamers();
            act.TopLevel = false;
            panel1.Controls.Add(act);
            act.Show();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Sub2totpldtm tot = new Sub2totpldtm();
            tot.TopLevel = false;
            panel1.Controls.Add(tot);
            tot.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FilterSub2 fil = new FilterSub2();
            fil.TopLevel = false;
            panel1.Controls.Add(fil);
            fil.Show();
        }
    }
}
