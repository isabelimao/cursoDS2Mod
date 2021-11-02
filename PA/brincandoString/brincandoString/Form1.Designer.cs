
namespace brincandoString
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
            this.btnMaiuscula = new System.Windows.Forms.Button();
            this.btnMinuscula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMaiuscula
            // 
            this.btnMaiuscula.Location = new System.Drawing.Point(79, 56);
            this.btnMaiuscula.Name = "btnMaiuscula";
            this.btnMaiuscula.Size = new System.Drawing.Size(96, 23);
            this.btnMaiuscula.TabIndex = 0;
            this.btnMaiuscula.Text = "MAIUSCULA";
            this.btnMaiuscula.UseVisualStyleBackColor = true;
            this.btnMaiuscula.Click += new System.EventHandler(this.btnMaiuscula_Click);
            // 
            // btnMinuscula
            // 
            this.btnMinuscula.Location = new System.Drawing.Point(287, 56);
            this.btnMinuscula.Name = "btnMinuscula";
            this.btnMinuscula.Size = new System.Drawing.Size(75, 23);
            this.btnMinuscula.TabIndex = 1;
            this.btnMinuscula.Text = "minuscula";
            this.btnMinuscula.UseVisualStyleBackColor = true;
            this.btnMinuscula.Click += new System.EventHandler(this.btnMinuscula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinuscula);
            this.Controls.Add(this.btnMaiuscula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaiuscula;
        private System.Windows.Forms.Button btnMinuscula;
        private System.Windows.Forms.Label label1;
    }
}

