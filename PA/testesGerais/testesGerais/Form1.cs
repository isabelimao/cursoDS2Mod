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

namespace testesGerais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome1, nome2, nome3, nome4;
            int jogadores;
            jogadores = Convert.ToInt32(Interaction.InputBox("Quantidade de Jogadores", ""));
            if (jogadores == 1)
            {
                nome1 = Convert.ToString(Interaction.InputBox("NOME DO JOGADOR", ""));
                MessageBox.Show("" + nome1);
            } else if (jogadores == 2)
            {
                nome1 = Convert.ToString(Interaction.InputBox("NOME DO PRIMEIRO JOGADOR", ""));
                nome2 = Convert.ToString(Interaction.InputBox("NOME DO SEGUNDO JOGADOR", ""));
                MessageBox.Show("O Jogador 1 é: " + nome1 + "\n O Jogador 2 é:" + nome2);
                string[] nomesJogadores = new string[2] {nome1, nome2};

                foreach (string nome in nomesJogadores)
                {
                    
                    if (nome.Contains("J") == true)
                    {
                        MessageBox.Show("" + nome);
                    }
                }
            } else if (jogadores == 3)
            {
                nome1 = Convert.ToString(Interaction.InputBox("NOME DO PRIMEIRO JOGADOR", ""));
                nome2 = Convert.ToString(Interaction.InputBox("NOME DO SEGUNDO JOGADOR", ""));
                nome3 = Convert.ToString(Interaction.InputBox("NOME DO TERCEIRO JOGADOR", ""));
                MessageBox.Show("O Jogador 1 é: " + nome1 + "\n O Jogador 2 é:" + nome2 +
                    "\nO Jogador 3 é: " + nome3);

            } else if (jogadores == 4) 
            {
                nome1 = Convert.ToString(Interaction.InputBox("NOME DO PRIMEIRO JOGADOR", ""));
                nome2 = Convert.ToString(Interaction.InputBox("NOME DO SEGUNDO JOGADOR", ""));
                nome3 = Convert.ToString(Interaction.InputBox("NOME DO TERCEIRO JOGADOR", ""));
                nome4 = Convert.ToString(Interaction.InputBox("NOME DO QUARTO JOGADOR", ""));
                MessageBox.Show("O Jogador 1 é: " + nome1 + "\n O Jogador 2 é:" + nome2 +
                    "\nO Jogador 3 é: " + nome3 + "\nO Jogador 4 é: " + nome4);
            }

        }
    }
}
