using System;
using System.Windows.Forms;
using Project_3.Helpers;

namespace Project_3
{
    public partial class Project3Data : Form
    {
        private Subgroep1 sg1;
        private Subgroep2 sg2;
        private Subgroep3 sg3;
        private debug debug;
        public Project3Data()
        {
            InitializeComponent();
            //Connect to the database as soon as the program starts up cuz we need it instantly.
            DbHelper dbHelp = new DbHelper();
            if(dbHelp.ConnectToDb())
            {
                Console.WriteLine("The connection was made successfully.");
            } else
            {
                MessageBox.Show("Database connection was unsuccessfull.\nClosing application...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Not really sure if this is proper way to exit the application but it works...
                Environment.Exit(1);
            }
        }

        private void LoadIntoPanel(Form frame)
        {
            panel1.Controls.Clear();
            frame.TopLevel = false;
            panel1.Controls.Add(frame);
            frame.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sg1 = new Subgroep1();
            this.LoadIntoPanel(sg1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sg2 = new Subgroep2();
            this.LoadIntoPanel(sg2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sg3 = new Subgroep3();
            this.LoadIntoPanel(sg3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            debug = new debug();
            this.LoadIntoPanel(debug);
        }
    }
}
