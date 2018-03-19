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
    public partial class Form2 : Form
    {

        private Population currPop;

        public Form2()
        {
            InitializeComponent();
            DBcon.InitializeDB();
        }

        private void Loadtbl1()
        {
            List<Population> pops = Population.GetPop();


            lvPops.Items.Clear();

            foreach (Population p in pops)
            {

                ListViewItem item = new ListViewItem(new String[] { p.Country_name, p.Country_population });
                item.Tag = p;

                lvPops.Items.Add(item);

            }



        }

        private void Loadtbl_Click(object sender, EventArgs e)
        {
            Loadtbl1();
        }

        private void lvPops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPops.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPops.SelectedItems[0];
                currPop = (Population)item.Tag;

                string Name = currPop.Country_name;
                string Pop = currPop.Country_population;

               
            }

        }

        

       
    }
}
