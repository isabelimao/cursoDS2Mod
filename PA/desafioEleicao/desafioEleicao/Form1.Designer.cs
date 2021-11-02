
namespace desafioEleicao
{
    partial class escolher_restaurante
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
            this.btnVotarC1 = new System.Windows.Forms.Button();
            this.lblVotar = new System.Windows.Forms.Label();
            this.lblSomaVoto1 = new System.Windows.Forms.Label();
            this.lblSomaVoto2 = new System.Windows.Forms.Label();
            this.lblSomaVoto3 = new System.Windows.Forms.Label();
            this.lblSomarTudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVotarC1
            // 
            this.btnVotarC1.Location = new System.Drawing.Point(120, 187);
            this.btnVotarC1.Name = "btnVotarC1";
            this.btnVotarC1.Size = new System.Drawing.Size(113, 29);
            this.btnVotarC1.TabIndex = 0;
            this.btnVotarC1.Text = "VOTAR";
            this.btnVotarC1.UseVisualStyleBackColor = true;
            this.btnVotarC1.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // lblVotar
            // 
            this.lblVotar.AutoSize = true;
            this.lblVotar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotar.Location = new System.Drawing.Point(93, 22);
            this.lblVotar.Name = "lblVotar";
            this.lblVotar.Size = new System.Drawing.Size(191, 29);
            this.lblVotar.TabIndex = 1;
            this.lblVotar.Text = "Clique aqui para votar! ";
            // 
            // lblSomaVoto1
            // 
            this.lblSomaVoto1.AutoSize = true;
            this.lblSomaVoto1.Location = new System.Drawing.Point(12, 309);
            this.lblSomaVoto1.Name = "lblSomaVoto1";
            this.lblSomaVoto1.Size = new System.Drawing.Size(77, 13);
            this.lblSomaVoto1.TabIndex = 5;
            this.lblSomaVoto1.Text = "SOMA VOTO1";
            this.lblSomaVoto1.Visible = false;
            // 
            // lblSomaVoto2
            // 
            this.lblSomaVoto2.AutoSize = true;
            this.lblSomaVoto2.Location = new System.Drawing.Point(12, 335);
            this.lblSomaVoto2.Name = "lblSomaVoto2";
            this.lblSomaVoto2.Size = new System.Drawing.Size(77, 13);
            this.lblSomaVoto2.TabIndex = 6;
            this.lblSomaVoto2.Text = "SOMA VOTO2";
            this.lblSomaVoto2.Visible = false;
            // 
            // lblSomaVoto3
            // 
            this.lblSomaVoto3.AutoSize = true;
            this.lblSomaVoto3.Location = new System.Drawing.Point(12, 358);
            this.lblSomaVoto3.Name = "lblSomaVoto3";
            this.lblSomaVoto3.Size = new System.Drawing.Size(83, 13);
            this.lblSomaVoto3.TabIndex = 7;
            this.lblSomaVoto3.Text = "SOMA VOTO33";
            this.lblSomaVoto3.Visible = false;
            // 
            // lblSomarTudo
            // 
            this.lblSomarTudo.AutoSize = true;
            this.lblSomarTudo.Location = new System.Drawing.Point(150, 358);
            this.lblSomarTudo.Name = "lblSomarTudo";
            this.lblSomarTudo.Size = new System.Drawing.Size(119, 13);
            this.lblSomarTudo.TabIndex = 8;
            this.lblSomarTudo.Text = "SOMA TODOS VOTOS";
            this.lblSomarTudo.Visible = false;
            // 
            // escolher_restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 423);
            this.Controls.Add(this.lblSomarTudo);
            this.Controls.Add(this.lblSomaVoto3);
            this.Controls.Add(this.lblSomaVoto2);
            this.Controls.Add(this.lblSomaVoto1);
            this.Controls.Add(this.lblVotar);
            this.Controls.Add(this.btnVotarC1);
            this.Name = "escolher_restaurante";
            this.Text = "Escolher restaurante";
            this.Load += new System.EventHandler(this.escolher_restaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVotarC1;
        private System.Windows.Forms.Label lblVotar;
        private System.Windows.Forms.Label lblSomaVoto1;
        private System.Windows.Forms.Label lblSomaVoto2;
        private System.Windows.Forms.Label lblSomaVoto3;
        private System.Windows.Forms.Label lblSomarTudo;
    }
}

