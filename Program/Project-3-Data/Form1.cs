using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

using Project_3_Data.Helpers;

namespace Project_3_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebHelper wh = new WebHelper("https://steamspy.com/");
            string result = wh.GetData("api.php", "request=appdetails&appid=730");
            JObject json = JObject.Parse(result);
            JObject data = json.Value<JObject>();

            int owners = data.Value<int>("owners");
            int price = data.Value<int>("price");
            int totalPrice = owners * price;
            richTextBox1.Text = data.Value<string>("name") + " is owned by " + data.Value<int>("owners") + " people which cost them all together $" + totalPrice.ToString();
        }
    }
}
