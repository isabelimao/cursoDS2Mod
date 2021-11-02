using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteriaApp
{
    public partial class loteria : Form
    {
        public loteria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random sorteado1 = new Random();  
            int numero1;
            numero1 = sorteado1.Next(0, 8 + 1); 

            lblNum1.Text = Convert.ToString(numero1);

            Random sorteado2 = new Random();
            int numero2;
            numero2 = sorteado2.Next(1, 9 - 1);

            lblNum2.Text = Convert.ToString(numero2);

            Random sorteado3 = new Random();
            int numero3;
            numero3 = sorteado3.Next(0, 9);

            lblNum3.Text = Convert.ToString(numero1);

            Random sorteado4 = new Random();
            int numero4;
            numero4 = sorteado4.Next(0, 9);

            lblNum4.Text = Convert.ToString(numero2);
        }
    }
}
