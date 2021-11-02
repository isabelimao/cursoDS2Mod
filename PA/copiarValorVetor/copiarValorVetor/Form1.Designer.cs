
namespace copiarValorVetor
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.lblSomaVetor = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(74, 119);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(86, 42);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(55, 74);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(126, 20);
            this.txtInserir.TabIndex = 1;
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Location = new System.Drawing.Point(52, 43);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(139, 13);
            this.lblCabecalho.TabIndex = 2;
            this.lblCabecalho.Text = "SOMAR VALORES ARRAY";
            // 
            // lblSomaVetor
            // 
            this.lblSomaVetor.AutoSize = true;
            this.lblSomaVetor.Location = new System.Drawing.Point(285, 43);
            this.lblSomaVetor.Name = "lblSomaVetor";
            this.lblSomaVetor.Size = new System.Drawing.Size(85, 13);
            this.lblSomaVetor.TabIndex = 5;
            this.lblSomaVetor.Text = "Somar 2 Vetores";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(265, 59);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(126, 20);
            this.txtV1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(265, 85);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(126, 20);
            this.txtV2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 321);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.lblSomaVetor);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCabecalho);
            this.Controls.Add(this.txtInserir);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.Label lblSomaVetor;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtV2;
    }
}

