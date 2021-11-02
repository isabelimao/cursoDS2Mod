
namespace somasEmediasComLacos
{
    partial class SomaMediaLaco
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSomarLista = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listDigitos = new System.Windows.Forms.ListBox();
            this.gbx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(189, 79);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(169, 53);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(113, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(170, 27);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(113, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(36, 34);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(120, 13);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Digite o primeiro número";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(36, 53);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(125, 13);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Digite o segundo número";
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.lblResultado);
            this.gbx1.Controls.Add(this.btnMedia);
            this.gbx1.Controls.Add(this.btnSomarLista);
            this.gbx1.Controls.Add(this.btnLimpar);
            this.gbx1.Controls.Add(this.listDigitos);
            this.gbx1.Controls.Add(this.lblNum2);
            this.gbx1.Controls.Add(this.lblNum1);
            this.gbx1.Controls.Add(this.txtNum1);
            this.gbx1.Controls.Add(this.txtNum2);
            this.gbx1.Controls.Add(this.btnCheck);
            this.gbx1.Location = new System.Drawing.Point(105, 92);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(335, 269);
            this.gbx1.TabIndex = 5;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "groupBox1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(248, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "label1";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(131, 174);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(86, 23);
            this.btnMedia.TabIndex = 8;
            this.btnMedia.Text = "Media Lista";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSomarLista
            // 
            this.btnSomarLista.Location = new System.Drawing.Point(131, 145);
            this.btnSomarLista.Name = "btnSomarLista";
            this.btnSomarLista.Size = new System.Drawing.Size(86, 23);
            this.btnSomarLista.TabIndex = 7;
            this.btnSomarLista.Text = "Somar Lista";
            this.btnSomarLista.UseVisualStyleBackColor = true;
            this.btnSomarLista.Click += new System.EventHandler(this.btnSomarLista_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(39, 223);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listDigitos
            // 
            this.listDigitos.FormattingEnabled = true;
            this.listDigitos.Location = new System.Drawing.Point(39, 109);
            this.listDigitos.Name = "listDigitos";
            this.listDigitos.Size = new System.Drawing.Size(86, 108);
            this.listDigitos.TabIndex = 5;
            // 
            // SomaMediaLaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 394);
            this.Controls.Add(this.gbx1);
            this.Name = "SomaMediaLaco";
            this.Text = "SomaMediaLaco";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.ListBox listDigitos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSomarLista;
        private System.Windows.Forms.Label lblResultado;
    }
}

