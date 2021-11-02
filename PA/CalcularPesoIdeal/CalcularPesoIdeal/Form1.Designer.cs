
namespace CalcularPesoIdeal
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
            this.radioHomem = new System.Windows.Forms.RadioButton();
            this.radioMulher = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioHomem
            // 
            this.radioHomem.AutoSize = true;
            this.radioHomem.Location = new System.Drawing.Point(159, 61);
            this.radioHomem.Name = "radioHomem";
            this.radioHomem.Size = new System.Drawing.Size(61, 17);
            this.radioHomem.TabIndex = 0;
            this.radioHomem.TabStop = true;
            this.radioHomem.Text = "Homem";
            this.radioHomem.UseVisualStyleBackColor = true;
            // 
            // radioMulher
            // 
            this.radioMulher.AutoSize = true;
            this.radioMulher.Location = new System.Drawing.Point(250, 61);
            this.radioMulher.Name = "radioMulher";
            this.radioMulher.Size = new System.Drawing.Size(57, 17);
            this.radioMulher.TabIndex = 1;
            this.radioMulher.TabStop = true;
            this.radioMulher.Text = "Mulher";
            this.radioMulher.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(156, 108);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(83, 26);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Digite sua altura\r\n (em mt)";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(252, 108);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(54, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(159, 158);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 22);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcule";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 319);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.radioMulher);
            this.Controls.Add(this.radioHomem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioHomem;
        private System.Windows.Forms.RadioButton radioMulher;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
    }
}

