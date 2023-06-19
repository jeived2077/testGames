using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form12 : Form
    {
        Thread f1f2;
        int i = 0;
        public Form12()
        {
            InitializeComponent();
        }

        public void Form12_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        
        
    }
}
