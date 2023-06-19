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
    public partial class Form4 : Form
    {
        int i = 0;
        int max = 300;
        public Form1 _form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860x-40" && Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.hard == "210MB")
            {
                Properties.Settings1.Default.system = "Windows 3.1";
                _form1.label9.Text = Properties.Settings1.Default.system;
                label8.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "пока нет" && Properties.Settings1.Default.pc == "пока нет" && Properties.Settings1.Default.cd == "пока нет" && Properties.Settings1.Default.hard == "пока нет")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label8.Text = "";
            }
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860x-40" && Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.hard == "210MB")
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label8.Text = "";
            }
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "3860x-66" && Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.hard == "850MB")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label8.Text = "";
            }
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                label8.Text = "";
            }
           
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "3860x-66" && Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.hard == "850MB")
            {
                Properties.Settings1.Default.system = "Windows 95";
                _form1.label9.Text = Properties.Settings1.Default.system;
                label8.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                Properties.Settings1.Default.system = "Windows 95";
                _form1.label9.Text = Properties.Settings1.Default.system;
                label8.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "32MB" && Properties.Settings1.Default.pc == "Pentium" && Properties.Settings1.Default.cd == "16xSpeed" && Properties.Settings1.Default.hard == "1.6GB")
            {
                Properties.Settings1.Default.system = "OS/2 5.0 Warp";

                label8.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Слабое железо"); }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;
            if (i > max)
            {
                timer1.Enabled = false;
                _form1.label9.Text = Properties.Settings1.Default.system;
                label8.Text = "готово";

            }

        }

        public void button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
