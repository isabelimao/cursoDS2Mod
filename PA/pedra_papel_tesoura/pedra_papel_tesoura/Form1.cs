using System;
using System.Drawing;
using System.Windows.Forms;

namespace pedra_papel_Tesoura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnPedra_CheckedChanged(object sender, EventArgs e)
        {
            pctUsuario.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/pedra.png");

        }

        private void rbtnPapel_CheckedChanged(object sender, EventArgs e)
        {

            pctUsuario.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/papel.png");

        }

        private void rbtnTesoura_CheckedChanged(object sender, EventArgs e)
        {

            pctUsuario.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/tesoura.png");

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random jokepo = new Random(); //Randomico é o que pega algo aleatóriamente

            int jogada2, res, pontU, pontPc;
            jogada2 = jokepo.Next(1, 4); // Retorna um randomico entre o valor minimo e até o valor máximo menos 1     
            res = Convert.ToInt32(lblRodada.Text);
            lblRodada.Text = (int.Parse(lblRodada.Text) + 1).ToString();
            pontU = Convert.ToInt32(lblPlacarJoga.Text); // Variável da pontuação do usuário
            pontPc = Convert.ToInt32(lblPlacarComp.Text); // Variável da pontuação do pc


            // USUARIO ESCOLHEU O RBTN PEDRA
            if (rbtnPedra.Checked == true)
            {
                switch (jogada2)
                {
                    case 1: //PEDRA COM PEDRA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/pedra.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Empate");
                        break;
                    case 2: //PEDRA COM PAPEL
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/papel.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Perdeu");
                        break;
                    case 3: //PEDRA COM TESOURA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/tesoura.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("GANHOU");
                        break;
                }

                // placar
                if (lblResVisual.Text == "GANHOU")
                {
                    groupPlacar.BackColor = Color.Green;
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Perdeu")
                {
                    groupPlacar.BackColor = Color.Red;
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Empate")
                {
                    groupPlacar.BackColor = Color.YellowGreen; // Cor do painel do game



                }
            } // fechei o if 


            // USUARIO ESCOLHEU O RBTN TESOURA
            if (rbtnTesoura.Checked == true)
            {
                switch (jogada2)
                {
                    case 1: //TESOURA COM PEDRA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/pedra.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Perdeu");
                        break;
                    case 2: //TESOURA COM PAPEL
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/papel.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("GANHOU");
                        break;
                    case 3: //TESOURA COM TESOURA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/tesoura.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Empatou");
                        break;
                }

                // placar
                if (lblResVisual.Text == "GANHOU")
                {
                    groupPlacar.BackColor = Color.Green;
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Perdeu")
                {
                    groupPlacar.BackColor = Color.Red;
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Empate")
                {
                    groupPlacar.BackColor = Color.YellowGreen; // Cor do painel do game


                }
            } // fechei o if 

            // USUARIO ESCOLHEU O RBTN PAPEL
            if (rbtnPapel.Checked == true)
            {
                switch (jogada2)
                {
                    case 1: //PAPEL COM PEDRA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/pedra.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("GANHOU");
                        break;
                    case 2: //PAPEL COM PAPEL
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/papel.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Empatou");
                        break;
                    case 3: //PAPEL COM TESOURA
                        pctPc.Load("C:/Users/J/Desktop/pedra_papel_Tesoura/pedra_papel_Tesoura/Resources/tesoura.png");
                        lblResVisual.Visible = true;
                        lblResVisual.Text = Convert.ToString("Perdeu");
                        break;
                }

                // placar
                if (lblResVisual.Text == "GANHOU")
                {
                    groupPlacar.BackColor = Color.Green;
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Perdeu")
                {
                    groupPlacar.BackColor = Color.Red;
                    lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) + 3).ToString(); //Coloca 3 pts no ganhador da rodada
                    lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) - 1).ToString(); //Tira 1 pt do perdedor da rodada

                }
                else if (lblResVisual.Text == "Empate")
                { 
                    groupPlacar.BackColor = Color.YellowGreen; // Cor do painel do game


                }
            } // fechei o if

            // Pontuação final
            if (res >= 9 && pontPc > pontU)
            {
                MessageBox.Show("O jogo acabou, você perdeu! A máquina fez: " + pontPc + " pts", "Loser!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) * 0).ToString(); // Zerar o placar do game
                lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) * 0).ToString(); // Zerar o placar do game
                lblResVisual.Visible = false; // Apaga onde aparece ganhou e perdeu
                lblRodada.Text = (int.Parse(lblRodada.Text) * 0).ToString(); // Zerar o número de rodadas do game
                groupPlacar.BackColor = Color.DimGray; // Cor do painel ao recomeçar o game
                return;

            } else if (res >= 9 && pontPc < pontU)
            {
                MessageBox.Show("O jogo acabou, você ganhou! Você fez: " + pontU + " pts", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) * 0).ToString();
                lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) * 0).ToString();
                lblResVisual.Visible = false;
                lblRodada.Text = (int.Parse(lblRodada.Text) * 0).ToString();
                groupPlacar.BackColor = Color.DimGray; 

                return;
            }


        } // fim  parte botão

        

        // BOTÃO PARA ZERAR 
        private void btnNovaPartida_Click(object sender, EventArgs e)
        {
            lblPlacarJoga.Text = (int.Parse(lblPlacarJoga.Text) * 0).ToString(); 
            lblPlacarComp.Text = (int.Parse(lblPlacarComp.Text) * 0).ToString();
            lblResVisual.Visible = false;
            rbtnPapel.Checked = false;
            rbtnTesoura.Checked = false;
            rbtnPedra.Checked = false;

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

            // button funciona também se apertar a tecla enter
            this.AcceptButton = btnPlay;
        }

        private void lblComputador_Click(object sender, EventArgs e)
        {

        }
    }
}


