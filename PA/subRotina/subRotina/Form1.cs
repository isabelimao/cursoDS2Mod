using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subRotina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LimparCheckBox()
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void txtValorIncial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) // 4 formas de converter em string
        {
            txtC1.Text = "134";
            txtC2.Text = "20";
            txtC3.Text = "50";
            txtC4.Text = "30";
        }

        private void txtValorIncial_TextChanged(object sender, EventArgs e)
        {
            if (txtValorIncial.Text == "")
                txtValorIncial.Text = 0.ToString();
            else
            {

                txtValorFinal.Text = txtValorIncial.Text;
                LimparCheckBox();
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) + Convert.ToDecimal(txtC1.Text));
            } else
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) - Convert.ToDecimal(txtC1.Text));
            }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) + Convert.ToDecimal(txtC2.Text));
            }
            else
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) - Convert.ToDecimal(txtC2.Text));
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) + Convert.ToDecimal(txtC3.Text));
            }
            else
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) - Convert.ToDecimal(txtC3.Text));
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) + Convert.ToDecimal(txtC4.Text));
            }
            else
            {
                txtValorFinal.Text = Convert.ToString(Convert.ToDecimal(txtValorFinal.Text) - Convert.ToDecimal(txtC4.Text));
            }
        }

       
    }
}
