
namespace listaRadioButton_Fotos
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
            this.pctChapolin = new System.Windows.Forms.PictureBox();
            this.pctSam = new System.Windows.Forms.PictureBox();
            this.pctPoucasTrancas = new System.Windows.Forms.PictureBox();
            this.pctQuaseNada = new System.Windows.Forms.PictureBox();
            this.rbtnChapolin = new System.Windows.Forms.RadioButton();
            this.rbtnQuaseNada = new System.Windows.Forms.RadioButton();
            this.rbtnSuperSam = new System.Windows.Forms.RadioButton();
            this.rbtnPoucasTrancas = new System.Windows.Forms.RadioButton();
            this.rbtnHerois = new System.Windows.Forms.RadioButton();
            this.rbtnViloes = new System.Windows.Forms.RadioButton();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLegenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctChapolin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoucasTrancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuaseNada)).BeginInit();
            this.SuspendLayout();
            // 
            // pctChapolin
            // 
            this.pctChapolin.Image = global::listaRadioButton_Fotos.Properties.Resources.chapolin;
            this.pctChapolin.Location = new System.Drawing.Point(157, 102);
            this.pctChapolin.Name = "pctChapolin";
            this.pctChapolin.Size = new System.Drawing.Size(127, 80);
            this.pctChapolin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctChapolin.TabIndex = 0;
            this.pctChapolin.TabStop = false;
            this.pctChapolin.Visible = false;
            // 
            // pctSam
            // 
            this.pctSam.Image = global::listaRadioButton_Fotos.Properties.Resources.supersam;
            this.pctSam.Location = new System.Drawing.Point(157, 236);
            this.pctSam.Name = "pctSam";
            this.pctSam.Size = new System.Drawing.Size(127, 80);
            this.pctSam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSam.TabIndex = 1;
            this.pctSam.TabStop = false;
            this.pctSam.Visible = false;
            // 
            // pctPoucasTrancas
            // 
            this.pctPoucasTrancas.Image = global::listaRadioButton_Fotos.Properties.Resources.PoucasTrancas;
            this.pctPoucasTrancas.Location = new System.Drawing.Point(481, 236);
            this.pctPoucasTrancas.Name = "pctPoucasTrancas";
            this.pctPoucasTrancas.Size = new System.Drawing.Size(127, 80);
            this.pctPoucasTrancas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPoucasTrancas.TabIndex = 2;
            this.pctPoucasTrancas.TabStop = false;
            this.pctPoucasTrancas.Visible = false;
            // 
            // pctQuaseNada
            // 
            this.pctQuaseNada.Image = global::listaRadioButton_Fotos.Properties.Resources.quase_nada;
            this.pctQuaseNada.Location = new System.Drawing.Point(481, 102);
            this.pctQuaseNada.Name = "pctQuaseNada";
            this.pctQuaseNada.Size = new System.Drawing.Size(127, 80);
            this.pctQuaseNada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctQuaseNada.TabIndex = 3;
            this.pctQuaseNada.TabStop = false;
            this.pctQuaseNada.Visible = false;
            // 
            // rbtnChapolin
            // 
            this.rbtnChapolin.AutoSize = true;
            this.rbtnChapolin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChapolin.Location = new System.Drawing.Point(290, 135);
            this.rbtnChapolin.Name = "rbtnChapolin";
            this.rbtnChapolin.Size = new System.Drawing.Size(96, 25);
            this.rbtnChapolin.TabIndex = 4;
            this.rbtnChapolin.TabStop = true;
            this.rbtnChapolin.Text = "Chapolin";
            this.rbtnChapolin.UseVisualStyleBackColor = true;
            this.rbtnChapolin.Visible = false;
            this.rbtnChapolin.CheckedChanged += new System.EventHandler(this.rbtnChapolin_CheckedChanged);
            // 
            // rbtnQuaseNada
            // 
            this.rbtnQuaseNada.AutoSize = true;
            this.rbtnQuaseNada.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuaseNada.Location = new System.Drawing.Point(614, 135);
            this.rbtnQuaseNada.Name = "rbtnQuaseNada";
            this.rbtnQuaseNada.Size = new System.Drawing.Size(122, 25);
            this.rbtnQuaseNada.TabIndex = 5;
            this.rbtnQuaseNada.TabStop = true;
            this.rbtnQuaseNada.Text = "Quase Nada";
            this.rbtnQuaseNada.UseVisualStyleBackColor = true;
            this.rbtnQuaseNada.Visible = false;
            this.rbtnQuaseNada.CheckedChanged += new System.EventHandler(this.rbtnQuaseNada_CheckedChanged);
            // 
            // rbtnSuperSam
            // 
            this.rbtnSuperSam.AutoSize = true;
            this.rbtnSuperSam.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSuperSam.Location = new System.Drawing.Point(290, 276);
            this.rbtnSuperSam.Name = "rbtnSuperSam";
            this.rbtnSuperSam.Size = new System.Drawing.Size(110, 25);
            this.rbtnSuperSam.TabIndex = 6;
            this.rbtnSuperSam.TabStop = true;
            this.rbtnSuperSam.Text = "Super Sam";
            this.rbtnSuperSam.UseVisualStyleBackColor = true;
            this.rbtnSuperSam.Visible = false;
            this.rbtnSuperSam.CheckedChanged += new System.EventHandler(this.rbtnSuperSam_CheckedChanged);
            // 
            // rbtnPoucasTrancas
            // 
            this.rbtnPoucasTrancas.AutoSize = true;
            this.rbtnPoucasTrancas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPoucasTrancas.Location = new System.Drawing.Point(614, 276);
            this.rbtnPoucasTrancas.Name = "rbtnPoucasTrancas";
            this.rbtnPoucasTrancas.Size = new System.Drawing.Size(145, 25);
            this.rbtnPoucasTrancas.TabIndex = 7;
            this.rbtnPoucasTrancas.TabStop = true;
            this.rbtnPoucasTrancas.Text = "Poucas Trancas";
            this.rbtnPoucasTrancas.UseVisualStyleBackColor = true;
            this.rbtnPoucasTrancas.Visible = false;
            this.rbtnPoucasTrancas.CheckedChanged += new System.EventHandler(this.rbtnPoucasTrancas_CheckedChanged);
            // 
            // rbtnHerois
            // 
            this.rbtnHerois.AutoSize = true;
            this.rbtnHerois.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHerois.Location = new System.Drawing.Point(185, 66);
            this.rbtnHerois.Name = "rbtnHerois";
            this.rbtnHerois.Size = new System.Drawing.Size(76, 25);
            this.rbtnHerois.TabIndex = 3;
            this.rbtnHerois.TabStop = true;
            this.rbtnHerois.Text = "Heróis";
            this.rbtnHerois.UseVisualStyleBackColor = true;
            this.rbtnHerois.CheckedChanged += new System.EventHandler(this.rbtnHerois_CheckedChanged);
            // 
            // rbtnViloes
            // 
            this.rbtnViloes.AutoSize = true;
            this.rbtnViloes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViloes.Location = new System.Drawing.Point(504, 66);
            this.rbtnViloes.Name = "rbtnViloes";
            this.rbtnViloes.Size = new System.Drawing.Size(73, 25);
            this.rbtnViloes.TabIndex = 4;
            this.rbtnViloes.TabStop = true;
            this.rbtnViloes.Text = "Vilões";
            this.rbtnViloes.UseVisualStyleBackColor = true;
            this.rbtnViloes.CheckedChanged += new System.EventHandler(this.rbtnViloes_CheckedChanged);
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.Location = new System.Drawing.Point(317, 26);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(153, 21);
            this.lblCabecalho.TabIndex = 10;
            this.lblCabecalho.Text = "Escolha o seu Lado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(210, 341);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(482, 341);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(37, 403);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(33, 15);
            this.lblLegenda.TabIndex = 11;
            this.lblLegenda.Text = "label1";
            this.lblLegenda.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCabecalho);
            this.Controls.Add(this.rbtnViloes);
            this.Controls.Add(this.rbtnHerois);
            this.Controls.Add(this.rbtnPoucasTrancas);
            this.Controls.Add(this.rbtnSuperSam);
            this.Controls.Add(this.rbtnQuaseNada);
            this.Controls.Add(this.rbtnChapolin);
            this.Controls.Add(this.pctQuaseNada);
            this.Controls.Add(this.pctPoucasTrancas);
            this.Controls.Add(this.pctSam);
            this.Controls.Add(this.pctChapolin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctChapolin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPoucasTrancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQuaseNada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctChapolin;
        private System.Windows.Forms.PictureBox pctSam;
        private System.Windows.Forms.PictureBox pctPoucasTrancas;
        private System.Windows.Forms.PictureBox pctQuaseNada;
        private System.Windows.Forms.RadioButton rbtnChapolin;
        private System.Windows.Forms.RadioButton rbtnQuaseNada;
        private System.Windows.Forms.RadioButton rbtnSuperSam;
        private System.Windows.Forms.RadioButton rbtnPoucasTrancas;
        private System.Windows.Forms.RadioButton rbtnHerois;
        private System.Windows.Forms.RadioButton rbtnViloes;
        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblLegenda;
    }
}

