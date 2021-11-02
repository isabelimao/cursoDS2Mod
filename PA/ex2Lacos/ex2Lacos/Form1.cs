using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double n1, n2, somat=0, media, cont,contNumeros=0;

            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            cont = n1;

            if (n1 < n2)
            {
                while (cont <= n2)
                {
                    somat = somat + cont;
                    contNumeros++;
                    cont++;
                }
                media = somat / contNumeros;
                MessageBox.Show("Soma: " + somat.ToString() +
                    "\nMédia: " + media.ToString());
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!!!!");
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double n1, n2, somat = 0, media, cont, contNumeros = 0;

            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            cont = n1;

            if (n1 < n2)
            {
                do
                {
                    somat = somat + cont;
                    contNumeros++;
                    cont++;
                } while (cont <= n2);
                media = somat / contNumeros;
                MessageBox.Show("Soma: " + somat.ToString() +
                    "\nMédia: " + media.ToString());
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!!!!");
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double n1, n2, somat = 0, media, cont, contNumeros = 0;

            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            cont = n1;

            if (n1 < n2)
            {
                for(cont=n1;cont<=n2;cont++)
                {
                    somat = somat + cont;
                    contNumeros++;
                } 
                media = somat / contNumeros;
                MessageBox.Show("Soma: " + somat.ToString() +
                    "\nMédia: " + media.ToString());
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!!!!");
            }
        }
    }
}
