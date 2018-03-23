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

        private void LoadFrame(Form stuff)
        {
            Panel1.Controls.Clear();
            stuff.TopLevel = false;
            Panel1.Controls.Add(stuff);
            stuff.Show();
        }

        private void Loadsub1()
        {
            Sub1 sub1 = new Sub1();
            this.LoadFrame(sub1);

        }

        private void Loadsub2()
        {
            Sub2 sub2 = new Sub2();
            this.LoadFrame(sub2);
        }

        private void Loadsub3()
        {
            Sub3 sub3 = new Sub3();
            this.LoadFrame(sub3);
        }

        private void Loadhelp()
        {
            Help help = new Help();
            this.LoadFrame(help);
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
            Panel1.Controls.Clear();
            Form2 frm2 = new Form2();
            frm2.TopLevel = false;
            Panel1.Controls.Add(frm2);
            frm2.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
