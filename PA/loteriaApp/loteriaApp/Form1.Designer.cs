
namespace loteriaApp
{
    partial class loteria
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
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Location = new System.Drawing.Point(355, 33);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(87, 13);
            this.lblCabecalho.TabIndex = 4;
            this.lblCabecalho.Text = "Número da Sorte";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(123, 107);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(84, 13);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "Primeiro Número";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(249, 107);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(90, 13);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "Segundo Número";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(381, 107);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(86, 13);
            this.lblNum3.TabIndex = 8;
            this.lblNum3.Text = "Terceiro Número";
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Location = new System.Drawing.Point(512, 107);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(79, 13);
            this.lblNum4.TabIndex = 9;
            this.lblNum4.Text = "Quarto Número";
            // 
            // loteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblCabecalho);
            this.Name = "loteria";
            this.Text = "Loteria ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
    }
}

