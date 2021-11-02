using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somarVariaveis_matematica
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        // HOJE VOCÊ TEM UM DESAFIO, JÁ DENTRO DESSE CÓDIGO, EXISTEM ALGUNS COMANDOS
        // QUE VOCÊ VAI UTILIZAR PARA PROGRAMAR O BOTÃO DE LIMPAR
        // FAÇA ESSA PROGRAMAÇÃO SOZINHO E DEPOIS ME FALE SE FUNCIONOU
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0".ToString();
            textBox2.Text = "0".ToString();
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            res = n1 + n2;
            textBox3.Text = Convert.ToString(res);

            if (textBox1.Text == "" || n1 < 0)
            {
                MessageBox.Show("Insira um número válido");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }   
        }      
    }
}
