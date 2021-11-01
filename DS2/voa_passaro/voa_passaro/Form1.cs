using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voa_passaro
{
    public partial class jogo : Form
    {
        private int velocidade = 5;
        private int gravidade = 5;
        private int pontos = 0;

        private void resetar()
        {
            picCanoBaixo.Visible = false;
            picCanoCima.Visible = false;
            picPassaro.Visible = false;
            lblAutor.Visible = false;
            lblGameOver.Visible = false;
            lblPts.Visible = false;
            btnReset.Visible = false;
            picCanoCima.Location = new Point(1250, picCanoCima.Location.Y);
            picCanoBaixo.Location = new Point(1100, picCanoCima.Location.Y);
            lblPts.Text = 0.ToString();
            pontos = 0;
            picPassaro.Location = new Point(200, 200);
            gameTimer.Start();
            velocidade = 5;


        }
        public jogo()
        {
            InitializeComponent();
            lblAutor.Text = "Criado Por Jefferson Lopes";
            lblGameOver.Text = "Loser";
            lblPts.Text = "Pontos: " + pontos;

            lblAutor.Visible = false;
            lblGameOver.Visible = false;
            lblPts.Visible = false;
            btnReset.Visible = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            picCanoCima.Left -= velocidade;
            picCanoBaixo.Left -= velocidade;
            picPassaro.Top -= gravidade;
            lblPts.Text = " " + pontos;
           

            // com 0 vai até o fim da tela, questão resolvida
            if(picCanoCima.Left < 0)
            {
                
                int size1;
                Random nPc = new Random();
                size1 = nPc.Next(50, 150); 
                picCanoCima.Left = 1250;
                picCanoCima.Location = new Point(1250, picCanoCima.Location.Y);
                /*velocidade++;*/
                pontos++;
                this.picCanoCima.Size = new System.Drawing.Size(size1, 200);
                lblNumVel.Text = Convert.ToString(pontos);

            }
            else if (picCanoBaixo.Left < 0)
            {
                int  size2;
                Random nPc1 = new Random();
                size2 = nPc1.Next(50, 150);
                picCanoBaixo.Left = 1100;
                picCanoBaixo.Location = new Point(1100, picCanoBaixo.Location.Y);
                /*velocidade++;*/
                pontos++;
                this.picCanoCima.Size = new System.Drawing.Size(size2 + 30, 200);
                lblNumVel.Text = Convert.ToString(pontos);
                
            }

            if (picPassaro.Bounds.IntersectsWith(picChao.Bounds)) endgame();
            if (picPassaro.Bounds.IntersectsWith(picCanoCima.Bounds)) endgame();
            if (picPassaro.Bounds.IntersectsWith(picCanoBaixo.Bounds)) endgame();

        }

        private void endgame()
        {
            gameTimer.Stop();
            lblAutor.Visible = true;
            lblGameOver.Visible = true;
            lblPts.Visible = true;
            lblPts2.Visible = true;
            lblPts.Text = Convert.ToString(pontos);
            lblPts2.Text = lblPts.Text;
            btnReset.Visible = true;
        }

        private void jogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravidade = -5;
        }

        private void jogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravidade = +5;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetar();
            btnReset.Visible = false;
        
        }
    }
}
