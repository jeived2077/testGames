using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public Form1 _form1;

        public Form7(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.money >= 5)
            {
                Properties.Settings1.Default.money = Properties.Settings1.Default.money - 5;
                _form1.label2.Text = Convert.ToString(Properties.Settings1.Default.money);
            }
            else
            {
                Properties.Settings1.Default.moon = "плохое";
                _form1.label11.Text = Properties.Settings1.Default.moon;
                MessageBox.Show("Недостачно денег");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.money >= 20)
            {
                Properties.Settings1.Default.money = Properties.Settings1.Default.money - 20;
                _form1.label2.Text = Convert.ToString(Properties.Settings1.Default.money);
            }
            else
            {
                MessageBox.Show("Недостачно денег");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                Properties.Settings1.Default.moon = "плохое";
                _form1.label11.Text = Properties.Settings1.Default.moon;
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {


            _form1.label2.Text = Convert.ToString(Properties.Settings1.Default.money);
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.money >= 30)
            {
                Properties.Settings1.Default.money = Properties.Settings1.Default.money - 30;
                _form1.label2.Text = Convert.ToString(Properties.Settings1.Default.money);
            }
            else
            {
                Properties.Settings1.Default.moon = "плохое";
                _form1.label11.Text = Properties.Settings1.Default.moon;
                MessageBox.Show("Недостачно денег");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}
