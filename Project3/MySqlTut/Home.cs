using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    public partial class Home : Form
    {

        
        
        public Home()
        {
            InitializeComponent();


        }

        private void Loadsub1()
        {
            Sub1 sub1 = new Sub1();
            sub1.Show();

        }

        private void Loadsub2()
        {
            Sub2 sub2 = new Sub2();
            sub2.Show();
        }

        private void Loadsub3()
        {
            Sub3 sub3 = new Sub3();
            sub3.Show();
        }

        private void Loadhelp()
        {
            Help hlp = new Help();
            hlp.Show();
        }

        private void Sub1_Click_1(object sender, EventArgs e)
        {
            Loadsub1();

        }

        private void Sub2_Click(object sender, EventArgs e)
        {
            Loadsub2();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Loadhelp();
        }


        private void Sub3_Click_1(object sender, EventArgs e)
        {
            Loadsub3();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
