using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ex3Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double cont, atual, anterior, proximo,termos;

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            anterior = 0;
            atual = 1;
            proximo = 1;

            termos = Convert.ToDouble(Interaction.InputBox("Digite o número de termos"));

            for(cont=1;cont<=termos;cont++)
            {
                lstResultado.Items.Add(atual.ToString());
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            } 
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            cont = 1;
            anterior = 0;
            atual = 1;
            proximo = 1;

            termos = Convert.ToDouble(Interaction.InputBox("Digite o número de termos"));

            do
            {
                lstResultado.Items.Add(atual.ToString());
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
                cont++;
            } while (cont <= termos);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            cont = 1;
            anterior = 0;
            atual = 1;
            proximo = 1;

            termos = Convert.ToDouble(Interaction.InputBox("Digite o número de termos"));

            while (cont <= termos)
            {
                lstResultado.Items.Add(atual.ToString());
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
                cont++;
            }
            
            
        }
    }
}
