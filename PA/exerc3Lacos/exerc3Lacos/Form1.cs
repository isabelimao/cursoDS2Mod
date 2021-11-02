
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerc3Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 0;
            double mediaAltura = 0, mediaIdade = 0, somaIdade = 0, somaAltura = 0, altura = 0, idade20=0,
                alunosAbaixo=0;

            for (int i = 0; i < 3; i++)
            {
                idade = Convert.ToInt32(Interaction.InputBox("Informe a sua idade:"));
                altura = Convert.ToDouble(Interaction.InputBox("Informe a sua altura:"));               
                if (idade > 20)
                {
                    idade20++;
                    somaAltura = somaAltura + altura;
                }
                if (altura < 1.7) 
                {
                    alunosAbaixo++;
                    somaIdade = somaIdade + idade;
                }
                mediaAltura = somaAltura / idade20;
                mediaIdade = somaIdade / alunosAbaixo;
            }
            MessageBox.Show("A idade média dos alunos com menos de 1,70m é: " + mediaIdade.ToString());
            MessageBox.Show("A altura média dos alunos com mais de 20 anos é: " + mediaAltura.ToString());
        }
    }
}
