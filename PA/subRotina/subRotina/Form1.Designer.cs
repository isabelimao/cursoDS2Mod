
namespace subRotina
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
            this.txtValorIncial = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC4 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.gpSup = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.lblTarifaInicial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTarifaFinal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorIncial
            // 
            this.txtValorIncial.Location = new System.Drawing.Point(140, 50);
            this.txtValorIncial.Name = "txtValorIncial";
            this.txtValorIncial.Size = new System.Drawing.Size(100, 20);
            this.txtValorIncial.TabIndex = 0;
            this.txtValorIncial.Text = "0";
            this.txtValorIncial.TextChanged += new System.EventHandler(this.txtValorIncial_TextChanged);
            this.txtValorIncial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorIncial_KeyPress);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(140, 370);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(100, 20);
            this.txtValorFinal.TabIndex = 1;
            this.txtValorFinal.Text = "0";
            // 
            // txtC2
            // 
            this.txtC2.Enabled = false;
            this.txtC2.Location = new System.Drawing.Point(104, 73);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(100, 20);
            this.txtC2.TabIndex = 2;
            // 
            // txtC4
            // 
            this.txtC4.Enabled = false;
            this.txtC4.Location = new System.Drawing.Point(453, 74);
            this.txtC4.Name = "txtC4";
            this.txtC4.Size = new System.Drawing.Size(100, 20);
            this.txtC4.TabIndex = 3;
            // 
            // txtC3
            // 
            this.txtC3.Enabled = false;
            this.txtC3.Location = new System.Drawing.Point(453, 19);
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(100, 20);
            this.txtC3.TabIndex = 4;
            // 
            // txtC1
            // 
            this.txtC1.Enabled = false;
            this.txtC1.Location = new System.Drawing.Point(104, 23);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(100, 20);
            this.txtC1.TabIndex = 5;
            // 
            // gpSup
            // 
            this.gpSup.Controls.Add(this.cb4);
            this.gpSup.Controls.Add(this.cb3);
            this.gpSup.Controls.Add(this.cb2);
            this.gpSup.Controls.Add(this.cb1);
            this.gpSup.Controls.Add(this.txtC1);
            this.gpSup.Controls.Add(this.txtC2);
            this.gpSup.Controls.Add(this.txtC4);
            this.gpSup.Controls.Add(this.txtC3);
            this.gpSup.Location = new System.Drawing.Point(55, 93);
            this.gpSup.Name = "gpSup";
            this.gpSup.Size = new System.Drawing.Size(559, 100);
            this.gpSup.TabIndex = 6;
            this.gpSup.TabStop = false;
            this.gpSup.Text = "groupBox1";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(18, 25);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(80, 17);
            this.cb1.TabIndex = 6;
            this.cb1.Text = "checkBox1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(18, 74);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(80, 17);
            this.cb2.TabIndex = 7;
            this.cb2.Text = "checkBox2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(367, 19);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(80, 17);
            this.cb3.TabIndex = 8;
            this.cb3.Text = "checkBox3";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(367, 76);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(80, 17);
            this.cb4.TabIndex = 9;
            this.cb4.Text = "checkBox4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // lblTarifaInicial
            // 
            this.lblTarifaInicial.AutoSize = true;
            this.lblTarifaInicial.Location = new System.Drawing.Point(52, 53);
            this.lblTarifaInicial.Name = "lblTarifaInicial";
            this.lblTarifaInicial.Size = new System.Drawing.Size(81, 13);
            this.lblTarifaInicial.TabIndex = 7;
            this.lblTarifaInicial.Text = "Tarifa Inicial R$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 98);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTarifaFinal
            // 
            this.lblTarifaFinal.AutoSize = true;
            this.lblTarifaFinal.Location = new System.Drawing.Point(52, 373);
            this.lblTarifaFinal.Name = "lblTarifaFinal";
            this.lblTarifaFinal.Size = new System.Drawing.Size(76, 13);
            this.lblTarifaFinal.TabIndex = 9;
            this.lblTarifaFinal.Text = "Tarifa Final R$";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(422, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(533, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTarifaFinal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTarifaInicial);
            this.Controls.Add(this.gpSup);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtValorIncial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpSup.ResumeLayout(false);
            this.gpSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorIncial;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC4;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.GroupBox gpSup;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label lblTarifaInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTarifaFinal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

