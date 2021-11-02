
namespace bloquearCaractereIndesejado
{
    partial class comprinhas
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblVtotal = new System.Windows.Forms.Label();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.rbtnVista = new System.Windows.Forms.RadioButton();
            this.rbtnParcelado = new System.Windows.Forms.RadioButton();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(86, 77);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(166, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Informe o valor do Produto em R$";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(86, 107);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(110, 13);
            this.lblQtd.TabIndex = 1;
            this.lblQtd.Text = "Informe a quantidade:";
            // 
            // lblVtotal
            // 
            this.lblVtotal.AutoSize = true;
            this.lblVtotal.Location = new System.Drawing.Point(174, 129);
            this.lblVtotal.Name = "lblVtotal";
            this.lblVtotal.Size = new System.Drawing.Size(78, 13);
            this.lblVtotal.TabIndex = 2;
            this.lblVtotal.Text = "Valor Total R$:";
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(162, 193);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPgto.TabIndex = 3;
            this.lblFormaPgto.Text = "Forma de Pagamento";
            this.lblFormaPgto.Visible = false;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(283, 74);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(283, 126);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 2;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(283, 100);
            this.nudQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(100, 20);
            this.nudQtde.TabIndex = 1;
            this.nudQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(89, 124);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(66, 22);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(105, 321);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "label5";
            this.lblMensagem.Visible = false;
            // 
            // rbtnVista
            // 
            this.rbtnVista.AutoSize = true;
            this.rbtnVista.Location = new System.Drawing.Point(177, 222);
            this.rbtnVista.Name = "rbtnVista";
            this.rbtnVista.Size = new System.Drawing.Size(58, 17);
            this.rbtnVista.TabIndex = 5;
            this.rbtnVista.TabStop = true;
            this.rbtnVista.Text = "À Vista";
            this.rbtnVista.UseVisualStyleBackColor = true;
            this.rbtnVista.Visible = false;
            this.rbtnVista.CheckedChanged += new System.EventHandler(this.rbtnVista_CheckedChanged);
            // 
            // rbtnParcelado
            // 
            this.rbtnParcelado.AutoSize = true;
            this.rbtnParcelado.Location = new System.Drawing.Point(177, 245);
            this.rbtnParcelado.Name = "rbtnParcelado";
            this.rbtnParcelado.Size = new System.Drawing.Size(104, 17);
            this.rbtnParcelado.TabIndex = 6;
            this.rbtnParcelado.TabStop = true;
            this.rbtnParcelado.Text = "Parcelado em 3x";
            this.rbtnParcelado.UseVisualStyleBackColor = true;
            this.rbtnParcelado.Visible = false;
            this.rbtnParcelado.CheckedChanged += new System.EventHandler(this.rbtnParcelado_CheckedChanged);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(283, 314);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 11;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(391, 416);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 22);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 416);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 22);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // comprinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.rbtnParcelado);
            this.Controls.Add(this.rbtnVista);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblFormaPgto);
            this.Controls.Add(this.lblVtotal);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblProduto);
            this.Name = "comprinhas";
            this.Text = "Comprinhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblVtotal;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.RadioButton rbtnVista;
        private System.Windows.Forms.RadioButton rbtnParcelado;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

