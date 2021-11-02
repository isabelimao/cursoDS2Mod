using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brincandoString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaiuscula_Click(object sender, EventArgs e)
        {
            string hello;
            hello = "Hello World";
            label1.Text = hello.ToUpper();
            MessageBox.Show("" + hello.Length);

        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            string hello;
            hello = "Hello World";
            label1.Text = hello.ToLower();
        }
    }
}
