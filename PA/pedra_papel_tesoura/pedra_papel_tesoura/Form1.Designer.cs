
namespace pedra_papel_Tesoura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pctPc = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResVisual = new System.Windows.Forms.Label();
            this.rbtnPedra = new System.Windows.Forms.RadioButton();
            this.rbtnPapel = new System.Windows.Forms.RadioButton();
            this.rbtnTesoura = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupPlacar = new System.Windows.Forms.GroupBox();
            this.lblPlacarComp = new System.Windows.Forms.Label();
            this.lblPlacarJoga = new System.Windows.Forms.Label();
            this.lblComputador = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.btnNovaPartida = new System.Windows.Forms.Button();
            this.lblRodada = new System.Windows.Forms.Label();
            this.LblRodadaEscrita = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc)).BeginInit();
            this.groupPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = global::pedra_papel_Tesoura.Properties.Resources.tesoura;
            this.pctUsuario.Location = new System.Drawing.Point(152, 135);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(147, 110);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 0;
            this.pctUsuario.TabStop = false;
            // 
            // pctPc
            // 
            this.pctPc.BackColor = System.Drawing.Color.Transparent;
            this.pctPc.Image = global::pedra_papel_Tesoura.Properties.Resources.papel;
            this.pctPc.Location = new System.Drawing.Point(565, 135);
            this.pctPc.Name = "pctPc";
            this.pctPc.Size = new System.Drawing.Size(134, 110);
            this.pctPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc.TabIndex = 1;
            this.pctPc.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(360, 307);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 49);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResVisual
            // 
            this.lblResVisual.AutoSize = true;
            this.lblResVisual.BackColor = System.Drawing.Color.Transparent;
            this.lblResVisual.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResVisual.Location = new System.Drawing.Point(330, 257);
            this.lblResVisual.Name = "lblResVisual";
            this.lblResVisual.Size = new System.Drawing.Size(200, 29);
            this.lblResVisual.TabIndex = 3;
            this.lblResVisual.Text = "Resultado final";
            this.lblResVisual.Visible = false;
            // 
            // rbtnPedra
            // 
            this.rbtnPedra.AutoSize = true;
            this.rbtnPedra.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPedra.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPedra.Location = new System.Drawing.Point(118, 294);
            this.rbtnPedra.Name = "rbtnPedra";
            this.rbtnPedra.Size = new System.Drawing.Size(95, 29);
            this.rbtnPedra.TabIndex = 4;
            this.rbtnPedra.TabStop = true;
            this.rbtnPedra.Text = "Pedra";
            this.rbtnPedra.UseVisualStyleBackColor = false;
            this.rbtnPedra.CheckedChanged += new System.EventHandler(this.rbtnPedra_CheckedChanged);
            // 
            // rbtnPapel
            // 
            this.rbtnPapel.AutoSize = true;
            this.rbtnPapel.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPapel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPapel.Location = new System.Drawing.Point(118, 336);
            this.rbtnPapel.Name = "rbtnPapel";
            this.rbtnPapel.Size = new System.Drawing.Size(91, 29);
            this.rbtnPapel.TabIndex = 5;
            this.rbtnPapel.TabStop = true;
            this.rbtnPapel.Text = "Papel";
            this.rbtnPapel.UseVisualStyleBackColor = false;
            this.rbtnPapel.CheckedChanged += new System.EventHandler(this.rbtnPapel_CheckedChanged);
            // 
            // rbtnTesoura
            // 
            this.rbtnTesoura.AutoSize = true;
            this.rbtnTesoura.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTesoura.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTesoura.Location = new System.Drawing.Point(118, 377);
            this.rbtnTesoura.Name = "rbtnTesoura";
            this.rbtnTesoura.Size = new System.Drawing.Size(118, 29);
            this.rbtnTesoura.TabIndex = 6;
            this.rbtnTesoura.TabStop = true;
            this.rbtnTesoura.Text = "Tesoura";
            this.rbtnTesoura.UseVisualStyleBackColor = false;
            this.rbtnTesoura.CheckedChanged += new System.EventHandler(this.rbtnTesoura_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(704, 426);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 48);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupPlacar
            // 
            this.groupPlacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupPlacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupPlacar.BackgroundImage")));
            this.groupPlacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupPlacar.Controls.Add(this.lblPlacarComp);
            this.groupPlacar.Controls.Add(this.lblPlacarJoga);
            this.groupPlacar.Controls.Add(this.lblRodada);
            this.groupPlacar.Controls.Add(this.LblRodadaEscrita);
            this.groupPlacar.Controls.Add(this.lblComputador);
            this.groupPlacar.Controls.Add(this.lblJogador);
            this.groupPlacar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPlacar.Location = new System.Drawing.Point(316, 117);
            this.groupPlacar.Name = "groupPlacar";
            this.groupPlacar.Size = new System.Drawing.Size(231, 137);
            this.groupPlacar.TabIndex = 8;
            this.groupPlacar.TabStop = false;
            this.groupPlacar.Text = "Placar";
            // 
            // lblPlacarComp
            // 
            this.lblPlacarComp.AutoSize = true;
            this.lblPlacarComp.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacarComp.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarComp.Location = new System.Drawing.Point(162, 63);
            this.lblPlacarComp.Name = "lblPlacarComp";
            this.lblPlacarComp.Size = new System.Drawing.Size(27, 25);
            this.lblPlacarComp.TabIndex = 3;
            this.lblPlacarComp.Text = "0";
            // 
            // lblPlacarJoga
            // 
            this.lblPlacarJoga.AutoSize = true;
            this.lblPlacarJoga.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacarJoga.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarJoga.Location = new System.Drawing.Point(39, 63);
            this.lblPlacarJoga.Name = "lblPlacarJoga";
            this.lblPlacarJoga.Size = new System.Drawing.Size(27, 25);
            this.lblPlacarJoga.TabIndex = 2;
            this.lblPlacarJoga.Text = "0";
            // 
            // lblComputador
            // 
            this.lblComputador.AutoSize = true;
            this.lblComputador.BackColor = System.Drawing.Color.Transparent;
            this.lblComputador.Location = new System.Drawing.Point(112, 27);
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(113, 18);
            this.lblComputador.TabIndex = 1;
            this.lblComputador.Text = "Computador";
            this.lblComputador.Click += new System.EventHandler(this.lblComputador_Click);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Location = new System.Drawing.Point(16, 27);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(75, 18);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "Jogador";
            // 
            // btnNovaPartida
            // 
            this.btnNovaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNovaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaPartida.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaPartida.Location = new System.Drawing.Point(360, 362);
            this.btnNovaPartida.Name = "btnNovaPartida";
            this.btnNovaPartida.Size = new System.Drawing.Size(146, 62);
            this.btnNovaPartida.TabIndex = 9;
            this.btnNovaPartida.Text = "Nova Partida";
            this.btnNovaPartida.UseVisualStyleBackColor = false;
            this.btnNovaPartida.Click += new System.EventHandler(this.btnNovaPartida_Click);
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblRodada.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodada.Location = new System.Drawing.Point(134, 105);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(23, 23);
            this.lblRodada.TabIndex = 10;
            this.lblRodada.Text = "0";
            // 
            // LblRodadaEscrita
            // 
            this.LblRodadaEscrita.AutoSize = true;
            this.LblRodadaEscrita.BackColor = System.Drawing.Color.Transparent;
            this.LblRodadaEscrita.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRodadaEscrita.Location = new System.Drawing.Point(68, 110);
            this.LblRodadaEscrita.Name = "LblRodadaEscrita";
            this.LblRodadaEscrita.Size = new System.Drawing.Size(73, 18);
            this.LblRodadaEscrita.TabIndex = 11;
            this.LblRodadaEscrita.Text = "Rodada:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(122, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(608, 60);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Pedra, Papel e Tesoura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNovaPartida);
            this.Controls.Add(this.groupPlacar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.rbtnTesoura);
            this.Controls.Add(this.rbtnPapel);
            this.Controls.Add(this.rbtnPedra);
            this.Controls.Add(this.lblResVisual);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pctPc);
            this.Controls.Add(this.pctUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jogo: Pedra, Papel e Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc)).EndInit();
            this.groupPlacar.ResumeLayout(false);
            this.groupPlacar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.PictureBox pctPc;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResVisual;
        private System.Windows.Forms.RadioButton rbtnPedra;
        private System.Windows.Forms.RadioButton rbtnPapel;
        private System.Windows.Forms.RadioButton rbtnTesoura;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupPlacar;
        private System.Windows.Forms.Label lblPlacarComp;
        private System.Windows.Forms.Label lblPlacarJoga;
        private System.Windows.Forms.Label lblComputador;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Button btnNovaPartida;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Label LblRodadaEscrita;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
    }
}

