using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeFatorial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeroConvertido = int.Parse(txtNumero.Text);
            int resultado = numeroConvertido;

            // caso especial 1 e 0
            if (resultado <= 1)
                resultado = 1;
            else
            {
                for (int i = 1; i < numeroConvertido; i++)
                {
                    resultado = resultado * i;
                }
            }
            MessageBox.Show("O valor fatorado é :" + resultado.ToString(), "Resultado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
