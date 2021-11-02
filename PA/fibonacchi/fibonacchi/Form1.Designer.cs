
namespace fibonacchi
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
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listDigitosFb = new System.Windows.Forms.ListBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNm1 = new System.Windows.Forms.TextBox();
            this.btnTermo = new System.Windows.Forms.Button();
            this.gbx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.btnLimpar);
            this.gbx1.Controls.Add(this.listDigitosFb);
            this.gbx1.Controls.Add(this.lblNum1);
            this.gbx1.Controls.Add(this.txtNm1);
            this.gbx1.Controls.Add(this.btnTermo);
            this.gbx1.Location = new System.Drawing.Point(233, 91);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(290, 269);
            this.gbx1.TabIndex = 6;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "groupBox1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 223);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listDigitosFb
            // 
            this.listDigitosFb.FormattingEnabled = true;
            this.listDigitosFb.Location = new System.Drawing.Point(101, 109);
            this.listDigitosFb.Name = "listDigitosFb";
            this.listDigitosFb.Size = new System.Drawing.Size(86, 108);
            this.listDigitosFb.TabIndex = 5;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(85, 38);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(112, 13);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Digite o F. que tu quer";
            // 
            // txtNm1
            // 
            this.txtNm1.Location = new System.Drawing.Point(101, 54);
            this.txtNm1.Name = "txtNm1";
            this.txtNm1.Size = new System.Drawing.Size(86, 20);
            this.txtNm1.TabIndex = 2;
            this.txtNm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNm1_KeyPress);
            // 
            // btnTermo
            // 
            this.btnTermo.Location = new System.Drawing.Point(101, 80);
            this.btnTermo.Name = "btnTermo";
            this.btnTermo.Size = new System.Drawing.Size(86, 23);
            this.btnTermo.TabIndex = 0;
            this.btnTermo.Text = "Check";
            this.btnTermo.UseVisualStyleBackColor = true;
            this.btnTermo.Click += new System.EventHandler(this.btnTermo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox listDigitosFb;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNm1;
        private System.Windows.Forms.Button btnTermo;
    }
}

