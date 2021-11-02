using System;
using System.Windows.Forms;

namespace bloquearCaractereIndesejado
{
    public partial class comprinhas : Form
    {
        public comprinhas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            txtProduto.Clear();
            txtValorTotal.Clear();
            txtProduto.Focus();
            nudQtde.Value = 1;

            lblFormaPgto.Visible = false;
            rbtnParcelado.Visible = false;
            rbtnVista.Visible = false;
            txtFinal.Visible = false;
            lblMensagem.Visible = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtValorTotal.Text = Convert.ToString(Convert.ToDecimal(txtProduto.Text) * nudQtde.Value);

            lblFormaPgto.Visible = true;
            rbtnParcelado.Visible = true;
            rbtnVista.Visible = true;

        }

        private void rbtnVista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVista.Checked == true)
            {
                txtFinal.Text = (Convert.ToDecimal(txtValorTotal.Text) * 0.9m).ToString();
                lblMensagem.Visible = true;
                lblMensagem.Text = "Valor com desconto de 10%: ";
                txtFinal.Visible = true;
            }
        }

        private void rbtnParcelado_CheckedChanged(object sender, EventArgs e)
        {
            txtFinal.Text = (Convert.ToDecimal(txtValorTotal.Text) / 3).ToString();
            lblMensagem.Visible = true;
            lblMensagem.Text = "Valor dividido em 3x (Por parcela): ";
            txtFinal.Visible = true;
        }
    }
}
