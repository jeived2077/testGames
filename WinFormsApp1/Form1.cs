using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;

using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        SoundPlayer music1 = new SoundPlayer(Properties.Resources.MUSIC);
        SoundPlayer music2 = new SoundPlayer(Properties.Resources.MUSIC2);
        SoundPlayer player = new SoundPlayer(Properties.Resources.CLICK);
        int month = Properties.Settings1.Default.month;
        int year = Properties.Settings1.Default.years;
        int i = 0;
        int day = Properties.Settings1.Default.day;


        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1000;

            timer1.Start();
            this.Text = Properties.Settings1.Default.user;
            label2.Text = Convert.ToString(Properties.Settings1.Default.money);
            label34.Text = Convert.ToString(Properties.Settings1.Default.point);
            label4.Text = Properties.Settings1.Default.status;
            label11.Text = Properties.Settings1.Default.moon;
            label23.Text = Properties.Settings1.Default.antivirus;
            label25.Text = Properties.Settings1.Default.program;
            label27.Text = Properties.Settings1.Default.bbs;
            label9.Text = Properties.Settings1.Default.system;
            label5.Text = Properties.Settings1.Default.pc;
            label15.Text = Properties.Settings1.Default.flash;
            label7.Text = Properties.Settings1.Default.hard;
            label19.Text = Properties.Settings1.Default.cd;
            label21.Text = Properties.Settings1.Default.soundblaster;
            label17.Text = Properties.Settings1.Default.modem;
            label32.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            if (Properties.Settings1.Default.money == 0)
            {
                Properties.Settings1.Default.moon = "плохое";
            }




        }


        public void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

            switch (DialogResult = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Закрыть программу", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    foreach (Form form2 in Application.OpenForms)
                    {
                        form2.Close();

                    }; break;
                case DialogResult.No: break;

            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.ShowDialog();
            player.Play();
        }



        public void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i >= 24)
            {

                i = 0;
                if (Properties.Settings1.Default.salary > 0)
                {
                    day++;
                    Properties.Settings1.Default.money = Properties.Settings1.Default.salary + Properties.Settings1.Default.money;
                    label2.Text = Convert.ToString(Properties.Settings1.Default.money);
                }
                else
                {
                    day++;
                    if (Properties.Settings1.Default.rdate + 15 == day)
                    {
                        MessageBox.Show("Игра окончена");
                    }
                }

            }

            label33.Text = (day + "." + month + "." + year);
            label30.Text = i.ToString("00") + ":00";

        }

        public void button7_Click(object sender, EventArgs e)
        {
            label2.Update();
        }

        public void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
            player.Play();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label23_Click(object sender, EventArgs e)
        {

        }

        public void label34_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void label32_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
            player.Play();

        }

        public void label35_Click(object sender, EventArgs e)
        {

        }

        public void сахранитьИгруToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document (*.fox) | *.fox| All Files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(Properties.Settings1.Default.money);
                        writer.WriteLine(Properties.Settings1.Default.point);
                        writer.WriteLine(Properties.Settings1.Default.moon);
                        writer.WriteLine(Properties.Settings1.Default.antivirus);
                        writer.WriteLine(Properties.Settings1.Default.program);
                        writer.WriteLine(Properties.Settings1.Default.bbs);
                        writer.WriteLine(Properties.Settings1.Default.system);
                        writer.WriteLine(Properties.Settings1.Default.pc);
                        writer.WriteLine(Properties.Settings1.Default.flash);
                        writer.WriteLine(Properties.Settings1.Default.hard);
                        writer.WriteLine(Properties.Settings1.Default.cd);
                        writer.WriteLine(Properties.Settings1.Default.soundblaster);
                        writer.WriteLine(Properties.Settings1.Default.modem);
                        writer.WriteLine(Properties.Settings1.Default.salary);
                        writer.WriteLine(Properties.Settings1.Default.job);
                        Properties.Settings1.Default.Save();
                    }
                    MessageBox.Show("Данные успешно сохранены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

        public void загрузитьИгруToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Document (*.fox) | *.fox| All Files (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = open.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        Properties.Settings1.Default.money = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.point = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.moon = reader.ReadLine();
                        Properties.Settings1.Default.antivirus = reader.ReadLine();
                        Properties.Settings1.Default.program = reader.ReadLine();
                        Properties.Settings1.Default.bbs = reader.ReadLine();
                        Properties.Settings1.Default.system = reader.ReadLine();
                        Properties.Settings1.Default.pc = reader.ReadLine();
                        Properties.Settings1.Default.flash = reader.ReadLine();
                        Properties.Settings1.Default.hard = reader.ReadLine();
                        Properties.Settings1.Default.cd = reader.ReadLine();
                        Properties.Settings1.Default.soundblaster = reader.ReadLine();
                        Properties.Settings1.Default.modem = reader.ReadLine();
                        Properties.Settings1.Default.salary = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.job = reader.ReadLine();
                        Properties.Settings1.Default.Save();
                    }
                    MessageBox.Show("Данные успешно загружены");
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }

        }

        public void новаяИграToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();


        }

        public void музыкаToolStripMenuItem_Click(object sender, EventArgs e)
        {



















        }

        public void button6_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(this);
            form.Show();
            player.Play();


        }

        public void музон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        public void button5_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(this);
            form.Show();
            player.Play();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            label31.Text = "Надо иметь статус юзер";
        }

        public void button6_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void button5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void button4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void button3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void button2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void звукиToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        public void музон1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        public void музон1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (музон1ToolStripMenuItem.Text == "Музон №1")
            {
                музон1ToolStripMenuItem.Text = "Музон №2";

                music1.Play();
            }
            else
            {
                музон1ToolStripMenuItem.Text = "Музон №1";

                music2.Play();
            }

        }

        public void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        public void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        public void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }
        public void trata()
        {
            if (Properties.Settings1.Default.money == 0)
            {
                Properties.Settings1.Default.moon = "Плохое";
                label11.Update();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }


}


