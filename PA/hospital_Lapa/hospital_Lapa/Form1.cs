using System;
using System.Windows.Forms;

namespace hospital_Lapa
{
    public partial class frmHospital : Form
    {
        public frmHospital()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Alt | Keys.A: // FAZ OS CALCULOS
                    calculos();
                    break;
                case Keys.Alt | Keys.C: // ABRE A CALCULADORA
                    System.Diagnostics.Process.Start("calc");
                    break;
                case Keys.Alt | Keys.E: // FECHA O PROGRAMA
                    Close();
                    break;
                case Keys.Alt | Keys.L: // LIMPA TUDO 
                    zeraCbx();
                    zerarRb();
                    txtNomePaciente.Clear();
                    break;

                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void zeraCbx()
        {
            cbxConsulta.Checked = false;
            cbxExamesLaboratoriais.Checked = false;
            cbxInternacao.Checked = false;
            lblTotalPlanoConvenio.Visible = false;
        }
        private void zerarRb()
        {
            rbtnAprazo.Checked = false;
            rbtnAvista.Checked = false;
            rbtnPartcular.Checked = false;
            rbtnPrivado.Checked = false;
            rbtnSus.Checked = false;
        }
        private void frmHospital_Load(object sender, EventArgs e)
        {
            lblConsulta.Text = "75";
            lblExames.Text = "150";
            lblInternacao.Text = "510";
            lblTotalPlanoConvenio.Text = "0";
            lblTotalServ.Text = "0";
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar)
               == true)
            {
                e.Handled = true;
            }
        }
        private void txtNomePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
        private void txtNomePaciente_TextChanged(object sender, EventArgs e)
        {
            if (txtNomePaciente.Text == "")
            {
                gbxPlanoSaude.Visible = false;
                gbxServicos.Visible = false;
                gbxFormaPgto.Visible = false;
                gbxOperacoes.Visible = false;
                txtTelefone.Visible = false;
            }
            else
            {
                gbxPlanoSaude.Visible = true;
                txtTelefone.Visible = true;
            }
        }
        private void cbxConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxConsulta.Checked == true)
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) + Convert.ToDecimal(lblConsulta.Text));
                lblConsulta.Visible = true;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) + Convert.ToDecimal(lblConsulta.Text));
                lblTotalServ.Visible = true;
                lblVtotalServicos.Visible = true;
            }
            else if (cbxConsulta.Checked == false)
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) - Convert.ToDecimal(lblConsulta.Text));
                lblConsulta.Visible = false;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) - Convert.ToDecimal(lblConsulta.Text));
                lblTotalServ.Visible = false;
            }
        }
        private void cbxInternacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxInternacao.Checked == true)
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) + Convert.ToDecimal(lblInternacao.Text));
                lblInternacao.Visible = true;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) + Convert.ToDecimal(lblInternacao.Text));
                lblTotalServ.Visible = true;
                lblVtotalServicos.Visible = true;
            }
            else
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) - Convert.ToDecimal(lblInternacao.Text));
                lblInternacao.Visible = false;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) - Convert.ToDecimal(lblInternacao.Text));
            }
        }
        private void cbxExamesLaboratoriais_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExamesLaboratoriais.Checked == true)
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) + Convert.ToDecimal(lblExames.Text));
                lblExames.Visible = true;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) + Convert.ToDecimal(lblExames.Text));
                lblTotalServ.Visible = true;
                lblVtotalServicos.Visible = true;
            }
            else
            {
                lblTotalPlanoConvenio.Text = Convert.ToString(Convert.ToDecimal(lblTotalPlanoConvenio.Text) - Convert.ToDecimal(lblExames.Text));
                lblExames.Visible = false;
                lblTotalServ.Text = Convert.ToString(Convert.ToDecimal(lblTotalServ.Text) - Convert.ToDecimal(lblExames.Text));
            }
        }
        private void rbtnSus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSus.Checked) //  SUS 
            {
                gbxServicos.Visible = true;
                lblCobrarGovernoPlano.Visible = true;
                gbxPrazoVista.Visible = false;
                gbxFormaPgto.Visible = true;
                lblTotalApagar.Visible = false;
                lblTotalPagar.Visible = false;
                btnCalcular.Visible = true;
                btnAbrirCalculadora.Visible = true;
                btnClose.Visible = true;
                btnClose.Visible = true;
            }
        }

        private void rbtnPrivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrivado.Checked) // FORMA PRIVADA OU CONVENIO
            {
                gbxServicos.Visible = true;
                lblCobrarGovernoPlano.Visible = true;
                gbxPrazoVista.Visible = false;
                gbxFormaPgto.Visible = true;
                lblTotalApagar.Visible = false;
                lblTotalPagar.Visible = false;
                btnCalcular.Visible = true;
                btnAbrirCalculadora.Visible = true;
                btnClose.Visible = true;
                btnClose.Visible = true;
            }
        }

        private void rbtnPartcular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPartcular.Checked) // FORMA SEM CONVENIO
            {
                gbxServicos.Visible = true;
                gbxPrazoVista.Visible = true;
                gbxFormaPgto.Visible = true;
                lblCobrarGovernoPlano.Visible = false;
                lblTotalApagar.Visible = true;
                lblTotalFormaPG.Visible = false;
                lblTotalPlanoConvenio.Visible = false;
                btnCalcular.Visible = true;
                btnAbrirCalculadora.Visible = true;
                btnClose.Visible = true;
                btnClose.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                calculos();
            }
        }

        private void calculos()
        {
            if (cbxConsulta.Checked == false && cbxExamesLaboratoriais.Checked == false && cbxInternacao.Checked == false)
            {
                MessageBox.Show("ESCOLHA ALGUM ITEM");
            }
            else if (rbtnSus.Checked || rbtnPrivado.Checked)
            {
                lblTotalPlanoConvenio.Visible = true;
                lblTotalPlanoConvenio.Text = lblTotalServ.Text;
                MessageBox.Show("R$ " + lblTotalServ.Text + ",00", "Preço final", MessageBoxButtons.OK, MessageBoxIcon.Information);
                zeraCbx();
                return;
            }
            else
            {
                if (rbtnAprazo.Checked == false && rbtnAvista.Checked == false)
                {
                    MessageBox.Show("ESCOLHA UMA FORMA DE PAGAMENTO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnAprazo.Checked)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = lblTotalServ.Text + " Sem AC/DC";
                    double desc, totalServ, res;
                    desc = 1.15;
                    totalServ = Convert.ToDouble(lblTotalServ.Text);
                    res = totalServ * desc;
                    MessageBox.Show("O valor vai ficar(com desconto): R$ " + res + ",00", "VALOR FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotalPagar.Visible = true;
                    lblTotalPagar.Text = Convert.ToString(res);
                    zeraCbx();
                    return;
                }
                else if (rbtnAvista.Checked)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = lblTotalServ.Text + " Sem AC/DC";
                    double desc, totalServ, res;
                    desc = 1.15;
                    totalServ = Convert.ToDouble(lblTotalServ.Text);
                    res = totalServ / desc;
                    MessageBox.Show("O valor vai ficar(com desconto): R$ " + res + ",00", "VALOR FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotalPagar.Visible = true;
                    lblTotalPagar.Text = Convert.ToString(res);
                    zeraCbx();
                    return;
                } // FIM DOS IFs 
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomePaciente.Clear();
            txtNomePaciente.Focus();
        }

        private void btnAbrirCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
