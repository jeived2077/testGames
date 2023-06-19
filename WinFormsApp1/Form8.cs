using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Компьютерщик Version 1.51\r\nПредставляю вашему вниманию\r\nмою новою игру Компьютерщик.\r\nЭта игра представляет из себя шутливый\r\nсимулятор\r\nжизни рядового компьютеромана с\r\nз лементами з кономики.\r\nНацеюсь вам понравится эта игра !\r\nИгра распространяется бесплатно !\r\nИгра требует совместимый\r\nкомпьютер\r\nС автором можно связаться по адресу:\r\nFidoNet- 2:5Ш5БПО.БFidoNet- 2:5Ш5БПО.Б\r\nCinsNet. 77:1 ,'51\r\nE•Mail - qweb777@yahoo, сот\r\nCopyright 1998 Ьу kokarev";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
