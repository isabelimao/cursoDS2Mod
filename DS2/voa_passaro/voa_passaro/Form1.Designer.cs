
namespace voa_passaro
{
    partial class jogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPts = new System.Windows.Forms.Label();
            this.picChao = new System.Windows.Forms.PictureBox();
            this.picCanoBaixo = new System.Windows.Forms.PictureBox();
            this.picCanoCima = new System.Windows.Forms.PictureBox();
            this.picPassaro = new System.Windows.Forms.PictureBox();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.lblNumVel = new System.Windows.Forms.Label();
            this.lblPts2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoCima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassaro)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(234, 163);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 13);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "lblAutor";
            this.lblAutor.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(296, 163);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(61, 13);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Location = new System.Drawing.Point(380, 163);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(21, 13);
            this.lblPts.TabIndex = 6;
            this.lblPts.Text = "pts";
            this.lblPts.Visible = false;
            // 
            // picChao
            // 
            this.picChao.Image = global::voa_passaro.Properties.Resources.chao;
            this.picChao.Location = new System.Drawing.Point(-4, 426);
            this.picChao.Name = "picChao";
            this.picChao.Size = new System.Drawing.Size(639, 50);
            this.picChao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChao.TabIndex = 3;
            this.picChao.TabStop = false;
            // 
            // picCanoBaixo
            // 
            this.picCanoBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanoBaixo.Image = global::voa_passaro.Properties.Resources.toppng_com_flappy_bird_pipe_transparent_281x1080;
            this.picCanoBaixo.Location = new System.Drawing.Point(477, -16);
            this.picCanoBaixo.Name = "picCanoBaixo";
            this.picCanoBaixo.Size = new System.Drawing.Size(97, 128);
            this.picCanoBaixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanoBaixo.TabIndex = 2;
            this.picCanoBaixo.TabStop = false;
            // 
            // picCanoCima
            // 
            this.picCanoCima.Image = global::voa_passaro.Properties.Resources.toppng_com_flappy_bird_pipe_transparent_281x1080;
            this.picCanoCima.Location = new System.Drawing.Point(382, 275);
            this.picCanoCima.Margin = new System.Windows.Forms.Padding(0);
            this.picCanoCima.Name = "picCanoCima";
            this.picCanoCima.Size = new System.Drawing.Size(100, 154);
            this.picCanoCima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanoCima.TabIndex = 1;
            this.picCanoCima.TabStop = false;
            // 
            // picPassaro
            // 
            this.picPassaro.Image = global::voa_passaro.Properties.Resources.pngwing_com;
            this.picPassaro.Location = new System.Drawing.Point(-4, 136);
            this.picPassaro.Name = "picPassaro";
            this.picPassaro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.picPassaro.Size = new System.Drawing.Size(172, 60);
            this.picPassaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassaro.TabIndex = 0;
            this.picPassaro.TabStop = false;
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(279, 183);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(40, 13);
            this.lblVelocidade.TabIndex = 7;
            this.lblVelocidade.Text = "Pontos";
            // 
            // lblNumVel
            // 
            this.lblNumVel.AutoSize = true;
            this.lblNumVel.Location = new System.Drawing.Point(346, 183);
            this.lblNumVel.Name = "lblNumVel";
            this.lblNumVel.Size = new System.Drawing.Size(0, 13);
            this.lblNumVel.TabIndex = 8;
            // 
            // lblPts2
            // 
            this.lblPts2.AutoSize = true;
            this.lblPts2.Location = new System.Drawing.Point(346, 183);
            this.lblPts2.Name = "lblPts2";
            this.lblPts2.Size = new System.Drawing.Size(21, 13);
            this.lblPts2.TabIndex = 9;
            this.lblPts2.Text = "pts";
            this.lblPts2.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(477, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Jogar Novamente";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(624, 474);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPts2);
            this.Controls.Add(this.lblNumVel);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.lblPts);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.picChao);
            this.Controls.Add(this.picCanoBaixo);
            this.Controls.Add(this.picCanoCima);
            this.Controls.Add(this.picPassaro);
            this.Name = "jogo";
            this.Text = "voaPassaro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jogo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jogo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picChao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanoCima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassaro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPassaro;
        private System.Windows.Forms.PictureBox picCanoCima;
        private System.Windows.Forms.PictureBox picCanoBaixo;
        private System.Windows.Forms.PictureBox picChao;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblNumVel;
        private System.Windows.Forms.Label lblPts2;
        private System.Windows.Forms.Button btnReset;
    }
}

