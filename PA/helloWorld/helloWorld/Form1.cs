using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string oi;
            oi = "Hello World";
            MessageBox.Show("" + oi.ToUpper());
            // EXISTEM METODOS PARA LETRAS/PALAVRAS
            // .toUpper() e o .toLower()

        }
    }
}
