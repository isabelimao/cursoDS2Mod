using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somasEmediasComLacos
{
    public partial class SomaMediaLaco : Form
    {
        public SomaMediaLaco()
        {
            InitializeComponent();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
                   == true)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) 
                   == true)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);

            if (num1 > num2)
            {
                MessageBox.Show("O segundo número precisa ser maior");
                txtNum1.Focus();
                return;
            } else if (num1 < 0 || num2 < 0)
            {
                MessageBox.Show("Precisa ser maior que zero");
            }

            for (int i = num1; i < num2 + 1; i++)
            {
                listDigitos.Items.Add(i.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listDigitos.Items.Clear();
            lblResultado.Visible = false;
            lblResultado.Text = "0";
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();

        }

        private void btnSomarLista_Click(object sender, EventArgs e)
        {
            var somatoria = 0;

            for (int i = 0; i < listDigitos.Items.Count; i++)
            {
                somatoria = somatoria + Convert.ToInt16(listDigitos.Items[i]);
                lblResultado.Text = Convert.ToString(somatoria);
                lblResultado.Visible = true;
            }            

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            var somatoria = 0;
            int num2;
            num2 = Convert.ToInt32(txtNum2.Text);

            for (int i = 0; i < listDigitos.Items.Count; i++)
            {
                int media;
                somatoria = somatoria + Convert.ToInt16(listDigitos.Items[i]);
                media = somatoria / num2;
                lblResultado.Text = Convert.ToString(media);
                lblResultado.Visible = true;
            }

        }
    }
}
