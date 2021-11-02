
namespace dadoVirtual
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
            this.btnDado = new System.Windows.Forms.Button();
            this.pctDado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDado
            // 
            this.btnDado.Location = new System.Drawing.Point(66, 176);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(132, 36);
            this.btnDado.TabIndex = 1;
            this.btnDado.Text = "button1";
            this.btnDado.UseVisualStyleBackColor = true;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click);
            // 
            // pctDado1
            // 
            this.pctDado1.Location = new System.Drawing.Point(67, 45);
            this.pctDado1.Name = "pctDado1";
            this.pctDado1.Size = new System.Drawing.Size(131, 98);
            this.pctDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDado1.TabIndex = 0;
            this.pctDado1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.btnDado);
            this.Controls.Add(this.pctDado1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctDado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDado1;
        private System.Windows.Forms.Button btnDado;
    }
}

