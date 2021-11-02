
namespace superTrunfo
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
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pctPc = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnAtaqueUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnDefesaUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnMagiaUsuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc)).BeginInit();
            this.SuspendLayout();
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = global::superTrunfo.Properties.Resources.zangief;
            this.pctUsuario.Location = new System.Drawing.Point(146, 76);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(137, 147);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 0;
            this.pctUsuario.TabStop = false;
            // 
            // pctPc
            // 
            this.pctPc.Image = global::superTrunfo.Properties.Resources.chunli;
            this.pctPc.Location = new System.Drawing.Point(522, 76);
            this.pctPc.Name = "pctPc";
            this.pctPc.Size = new System.Drawing.Size(137, 147);
            this.pctPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc.TabIndex = 1;
            this.pctPc.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnAtaqueUsuario
            // 
            this.rbtnAtaqueUsuario.AutoSize = true;
            this.rbtnAtaqueUsuario.Location = new System.Drawing.Point(157, 271);
            this.rbtnAtaqueUsuario.Name = "rbtnAtaqueUsuario";
            this.rbtnAtaqueUsuario.Size = new System.Drawing.Size(85, 17);
            this.rbtnAtaqueUsuario.TabIndex = 3;
            this.rbtnAtaqueUsuario.TabStop = true;
            this.rbtnAtaqueUsuario.Text = "radioButton1";
            this.rbtnAtaqueUsuario.UseVisualStyleBackColor = true;
            // 
            // rbtnDefesaUsuario
            // 
            this.rbtnDefesaUsuario.AutoSize = true;
            this.rbtnDefesaUsuario.Location = new System.Drawing.Point(157, 294);
            this.rbtnDefesaUsuario.Name = "rbtnDefesaUsuario";
            this.rbtnDefesaUsuario.Size = new System.Drawing.Size(85, 17);
            this.rbtnDefesaUsuario.TabIndex = 4;
            this.rbtnDefesaUsuario.TabStop = true;
            this.rbtnDefesaUsuario.Text = "radioButton2";
            this.rbtnDefesaUsuario.UseVisualStyleBackColor = true;
            // 
            // rbtnMagiaUsuario
            // 
            this.rbtnMagiaUsuario.AutoSize = true;
            this.rbtnMagiaUsuario.Location = new System.Drawing.Point(157, 317);
            this.rbtnMagiaUsuario.Name = "rbtnMagiaUsuario";
            this.rbtnMagiaUsuario.Size = new System.Drawing.Size(85, 17);
            this.rbtnMagiaUsuario.TabIndex = 5;
            this.rbtnMagiaUsuario.TabStop = true;
            this.rbtnMagiaUsuario.Text = "radioButton3";
            this.rbtnMagiaUsuario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnMagiaUsuario);
            this.Controls.Add(this.rbtnDefesaUsuario);
            this.Controls.Add(this.rbtnAtaqueUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctPc);
            this.Controls.Add(this.pctUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.PictureBox pctPc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnAtaqueUsuario;
        private System.Windows.Forms.RadioButton rbtnDefesaUsuario;
        private System.Windows.Forms.RadioButton rbtnMagiaUsuario;
    }
}

