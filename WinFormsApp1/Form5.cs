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
    public partial class Form5 : Form
    {
        public Form1 _form1;
        public Form5(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Form5_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет")
            {
                button1.Text = "Купить компьютер";

            }
            if (Properties.Settings1.Default.modem == "Пока нет")
            {
                button5.Text = "Купить модем";
            }
            if (Properties.Settings1.Default.hard == "Пока нет")
            {
                button4.Text = "Купить винчестер";
            }
            if (Properties.Settings1.Default.cd == "Пока нет")
            {
                button6.Text = "Купить cd";
            }
            if (Properties.Settings1.Default.soundblaster == "Пока нет")
            {
                button7.Text = "Купить soundblaster";
            }
            else
            {
                button7.Enabled = false;
            }
            if (Properties.Settings1.Default.flash == "Пока нет")
            {
                button3.Text = "Купить память";
            }
            
            if (Properties.Settings1.Default.pc == "3860х-40")
            {
                button1.Text = "улучшить пк";
            }
            
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                button1.Text = "улучшить пк";
            }
            if (Properties.Settings1.Default.pc == "Pentium")
            {
                button1.Text = "улучшить пк";
            }
           

            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                button3.Text = "улучшить память";
            }
            
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                button3.Text = "улучшить память";
            }
            
            if (Properties.Settings1.Default.pc == "3860х-66")
            { 
                button4.Text = "улучшить хард";
            }
            
            if (Properties.Settings1.Default.hard == "210MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                button4.Text = "улучшить хард";
            }
            if (Properties.Settings1.Default.hard == "850MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                button4.Text = "улучшить хард";
            }
            
            if (Properties.Settings1.Default.modem == "2400bit" && Properties.Settings1.Default.pc == "3860х-66")
            {
                
                button5.Text = "улучшить модем";
            }

            if (Properties.Settings1.Default.modem == "14400bit" && Properties.Settings1.Default.pc == "Pentium")
            {
                
                button5.Text = "улучшить модем";
            }
           
            if (Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.pc == "3860х-66")
            {
                
                button6.Text = "улучшить cd";
            }
            
            if (Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.pc == "Pentium")
            {
                
                button6.Text = "улучшить cd";
            }
            



        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (Properties.Settings1.Default.money < 10)
            {
                MessageBox.Show("Недостаточно денег для покупки компьютера");
            }
            else if (Properties.Settings1.Default.pc == "Пока нет")
            {
                Properties.Settings1.Default.money = Properties.Settings1.Default.money - 10;
                Properties.Settings1.Default.pc = "3860х-40";
                _form1.label5.Text = Convert.ToString(Properties.Settings1.Default.pc);
            }
            else if (Properties.Settings1.Default.pc == "3860х-40")
            {
                if (Properties.Settings1.Default.money < 30)
                {
                    MessageBox.Show("Недостаточно денег для покупки компьютера");
                }
                else
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 30;
                    Properties.Settings1.Default.pc = "3860х-66";
                    _form1.label5.Text = Convert.ToString(Properties.Settings1.Default.pc);
                }
            }
            else if (Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money < 80)
                {
                    MessageBox.Show("Недостаточно денег для покупки компьютера");
                }
                else
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 80;
                    Properties.Settings1.Default.pc = "Pentium";
                    _form1.label5.Text = Convert.ToString(Properties.Settings1.Default.pc);
                }
            }
            else
            {
                MessageBox.Show("У вас уже есть компьютер");
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            
                if (Properties.Settings1.Default.pc == "3860х-66")
                {
                    if (Properties.Settings1.Default.money >= 5)
                    {
                        Properties.Settings1.Default.money -= 5;
                        Properties.Settings1.Default.flash = "4MB";
                    _form1.label15.Text = Convert.ToString(Properties.Settings1.Default.flash);
                }
                    else
                    {
                        MessageBox.Show("Мало денег");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Нету pc");
                    return;
                }
                if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860х-66")
                {
                    if (Properties.Settings1.Default.money >= 15)
                    {
                        Properties.Settings1.Default.money -= 15;
                        Properties.Settings1.Default.flash = "16MB";
                    _form1.label15.Text = Convert.ToString(Properties.Settings1.Default.flash);
                }
                    else
                    {
                        MessageBox.Show("Мало денег");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточно мощности ПК");
                    return;
                }
                if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "Pentium")
                {
                    if (Properties.Settings1.Default.money >= 20)
                    {
                        Properties.Settings1.Default.money -= 20;
                        Properties.Settings1.Default.flash = "32MB";
                    _form1.label15.Text = Convert.ToString(Properties.Settings1.Default.flash);
                    }
                    else
                    {
                        MessageBox.Show("Мало денег");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточно мощности ПК");
                    return;
                }
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money >= 20)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 20;
                    Properties.Settings1.Default.hard = "210MB";
                    _form1.label7.Text = Convert.ToString(Properties.Settings1.Default.hard);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Нету pc");
                return;
            }
            if (Properties.Settings1.Default.hard == "210MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money >= 50)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 50;
                    Properties.Settings1.Default.hard = "850MB";
                    _form1.label7.Text = Convert.ToString(Properties.Settings1.Default.hard);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
                return;
            }
            if (Properties.Settings1.Default.hard == "850MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                if (Properties.Settings1.Default.money >= 100)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 100;
                    Properties.Settings1.Default.hard = "1.6GB";
                    _form1.label7.Text = Convert.ToString(Properties.Settings1.Default.hard);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
                return;
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money >= 25)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 25;
                    Properties.Settings1.Default.modem = "2400bit";
                    _form1.label17.Text = Convert.ToString(Properties.Settings1.Default.modem);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
            else
            {
                MessageBox.Show("Нету pc");
            }
            if (Properties.Settings1.Default.modem == "2400bit" && Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money >= 25)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 25;
                    Properties.Settings1.Default.modem = "14400bit";
                    _form1.label17.Text = Convert.ToString(Properties.Settings1.Default.modem);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }

            if (Properties.Settings1.Default.modem == "14400bit" && Properties.Settings1.Default.pc == "Pentium")
            {
                if (Properties.Settings1.Default.money >= 50)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 50;
                    Properties.Settings1.Default.modem = "28800bit";
                    _form1.label17.Text = Convert.ToString(Properties.Settings1.Default.modem);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                Properties.Settings1.Default.money = Properties.Settings1.Default.money - 30;
                Properties.Settings1.Default.cd = "4xSpeed";
                _form1.label19.Text = Convert.ToString(Properties.Settings1.Default.cd);
            }
            else
            {
                MessageBox.Show("Нету pc");
            }

           if (Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.pc == "3860х-66")
            {
                if (Properties.Settings1.Default.money >= 50)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 50;
                    Properties.Settings1.Default.cd = "8xSpeed";
                    _form1.label19.Text = Convert.ToString(Properties.Settings1.Default.cd);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег!");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }

            if (Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.pc == "Pentium")
            {
                if (Properties.Settings1.Default.money >= 80)
                {
                    Properties.Settings1.Default.money = Properties.Settings1.Default.money - 80;
                    Properties.Settings1.Default.cd = "16xSpeed";
                    _form1.label19.Text = Convert.ToString(Properties.Settings1.Default.cd);
                }
                else
                {
                    MessageBox.Show("Недостаточно денег!");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег или слабый пк");
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {

        }

        public void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.pc == "Пока нет")
            {
                label3.Text = "Сейчас можно купить\r\n386DX-40 за 10$";

            }
            if (Properties.Settings1.Default.pc == "3860х-40")
            {

                label3.Text = "Сейчас можно купить\r\n386DX-66 за 30$";
            }
            
            if (Properties.Settings1.Default.pc == "3860х-66")
            {
                label3.Text = "Сейчас можно купить\r\nPentium за 80$";
            }
            
        }

        public void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.flash == "Пока нет")
            {
                label3.Text = "Сейчас можно купить 4Mb памяти за 5$";
            }
            if (Properties.Settings1.Default.flash == "4MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label3.Text = "Сейчас можно купить 16Mb памяти за 15$";
                Properties.Settings1.Default.flash = "16MB";
            }
            
            if (Properties.Settings1.Default.flash == "16MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                label3.Text = "Сейчас можно купить 32Mb памяти за 20$";
                
            }
            


        }

        public void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.hard == "Пока нет")
            {
                label3.Text = "Сейчас можно купить винт на 21ОМЬ за 20$";
            }
            if (Properties.Settings1.Default.hard == "210MB" && Properties.Settings1.Default.pc == "3860х-66")
            {
                label3.Text = "Сейчас можно купить винт на 850MB за 50$";
            }
            if (Properties.Settings1.Default.hard == "850MB" && Properties.Settings1.Default.pc == "Pentium")
            {
                label3.Text = "Сейчас можно купить винт на 1.6GB за 50$";
            }



        }
            
                




            

        public void button5_MouseMove(object sender, MouseEventArgs e)
        {

            if (Properties.Settings1.Default.modem == "Пока нет")
            {
                label3.Text = "Можно купить модем на 2400bit за 10$";
            }
            if (Properties.Settings1.Default.modem == "2400bit" && Properties.Settings1.Default.pc == "3860х-66")
            {
                
                label3.Text = "Можно купить модем на 14400bit за 25$";
            }
            

            if (Properties.Settings1.Default.modem == "14400bit" && Properties.Settings1.Default.pc == "Pentium")
            {
                
                label3.Text = "Можно купить модем на 28800bit за 50$";
            }
            

        }

        public void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.cd == "Пока нет")
            {
                label1.Text = "Доступен СО-ВОМ\r\n4xSpeed за 30$";
            }
            if (Properties.Settings1.Default.cd == "4xSpeed" && Properties.Settings1.Default.pc == "3860х-66")
            {
                
                label3.Text = "Доступен СО-ВОМ\r\n8xSpeed за 50$";
            }
            
            if (Properties.Settings1.Default.cd == "8xSpeed" && Properties.Settings1.Default.pc == "Pentium")
            {
                
                label3.Text = "Доступен СО-ВОМ\r\n16xSpeed за 80$";
            }
            
        }

        public void button7_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.soundblaster == "Пока нет")
            {
                label3.Text = "Вы можете купить\r\nSoundBlaster за 50$";
            }
        }
    }
}
