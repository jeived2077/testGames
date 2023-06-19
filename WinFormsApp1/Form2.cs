using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.Properties;
using System.Diagnostics.Metrics;
using System.Data.SqlTypes;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Thread f1f2;
        int i = 0;
        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.INTRO);
        System.Media.SoundPlayer sndd = new System.Media.SoundPlayer(Properties.Resources.INTRO2);

        public Form2()
        {
            InitializeComponent();

        }



        public void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                Properties.Settings1.Default.user = "Анонимный компьютерщик";
            }
            else { Properties.Settings1.Default.user = this.textBox1.Text; }
            this.Close();
            Thread f1f2;
            this.Close();
            f1f2 = new Thread(open);
            f1f2.SetApartmentState(ApartmentState.STA);
            f1f2.Start();


            i = 0;

            snd.Stop();
            sndd.Stop();









        }

        public void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            Properties.Settings1.Default.money = 60;
            Properties.Settings1.Default.point = 0;
            Properties.Settings1.Default.moon = "нормальное";
            Properties.Settings1.Default.antivirus = "отсутсвует";
            Properties.Settings1.Default.program = "отсутсвует";
            Properties.Settings1.Default.bbs = "отсутсвует";
            Properties.Settings1.Default.system = "отсутсвует";
            Properties.Settings1.Default.pc = "Пока нет";
            Properties.Settings1.Default.flash = "Пока нет";
            Properties.Settings1.Default.hard = "Пока нет";
            Properties.Settings1.Default.cd = "Пока нет";
            Properties.Settings1.Default.soundblaster = "Пока нет";
            Properties.Settings1.Default.modem = "Пока нет";
            Properties.Settings1.Default.status = "Чайник";
            Properties.Settings1.Default.job = "Безработный";
            Properties.Settings1.Default.salary = 0;
            Properties.Settings1.Default.month = DateTime.Now.Month;
            Properties.Settings1.Default.day = DateTime.Now.Day;
            Properties.Settings1.Default.years = DateTime.Now.Year;
            Properties.Settings1.Default.time = 0;
            Properties.Settings1.Default.Save();




        }

        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            i++;

            switch (i)
            {

                case 1:


                    snd.Play(); break;
                case 4:


                    sndd.Play(); break;
                case 136: i = 0; break;

            }



        }
        public void open(object obj)
        {
            Application.Run(new Form1());
        }

        public void музон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vToolStripMenuItem.Checked = true)
            {
                timer1.Start();


            }
            else
            {

                snd.Stop();
                sndd.Stop();

            }
        }

        public void вкратцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();

        }

        public void описаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        public void разноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        public void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }
    }

}
