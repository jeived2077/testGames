using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public void Form10_Load(object sender, EventArgs e)
        {
            label1.Text = "Игра написана под Windows95DH\r\nвизуальными средствами за 2 месяца\r\nПобудила меня на написание этой иг-\r\nры очень известная многим игра Fido.\r\nЮрия Нестеренко. за что ему большое\r\nспасибо !\r\nТ акже я благодарю всех бета тесте-\r\nров. которые тестировали эту игру !";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
