using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form1 _form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.job = "Дворник";
            Properties.Settings1.Default.salary = 10;
            _form1.label32.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.rdate + 15 < Properties.Settings1.Default.day)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

            }
            if (Properties.Settings1.Default.rdate + 15 == Properties.Settings1.Default.day)
            {
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

            }


        }

        public void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.job = "Слесарь";
            Properties.Settings1.Default.salary = 20;
            _form1.label32.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
