
namespace exVetoresPa
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
            this.btnInciar = new System.Windows.Forms.Button();
            this.lstQuadrado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInciar
            // 
            this.btnInciar.Location = new System.Drawing.Point(8, 8);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(170, 27);
            this.btnInciar.TabIndex = 0;
            this.btnInciar.Text = "Iniciar";
            this.btnInciar.UseVisualStyleBackColor = true;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // lstQuadrado
            // 
            this.lstQuadrado.FormattingEnabled = true;
            this.lstQuadrado.Location = new System.Drawing.Point(8, 50);
            this.lstQuadrado.Name = "lstQuadrado";
            this.lstQuadrado.Size = new System.Drawing.Size(169, 264);
            this.lstQuadrado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 344);
            this.Controls.Add(this.lstQuadrado);
            this.Controls.Add(this.btnInciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInciar;
        private System.Windows.Forms.ListBox lstQuadrado;
    }
}

