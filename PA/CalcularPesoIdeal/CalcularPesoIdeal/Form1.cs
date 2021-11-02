using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float altura, pesoH, pesoM;

            altura = float.Parse(txtAltura.Text);

            pesoH = (72.7f * altura - 58.0f);
            pesoM = (62.1f * altura - 44.7f);

            if(radioHomem.Checked == true)
            {
                MessageBox.Show("Seu peso ideal é de: "
                + pesoH.ToString("0.00"), "Peso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (radioMulher.Checked == true)
            {
                MessageBox.Show("Seu peso ideal é de: "
                + pesoM.ToString("0.00"), "Peso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
