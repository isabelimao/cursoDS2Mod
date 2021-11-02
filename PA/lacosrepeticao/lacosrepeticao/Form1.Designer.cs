
namespace lacosrepeticao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnLacoDo = new System.Windows.Forms.Button();
            this.btnTabuadaFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABUADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um número";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.Location = new System.Drawing.Point(109, 235);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(142, 173);
            this.lstTabuada.TabIndex = 3;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(130, 134);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(97, 23);
            this.btnTabuada.TabIndex = 4;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnLacoDo
            // 
            this.btnLacoDo.Location = new System.Drawing.Point(130, 163);
            this.btnLacoDo.Name = "btnLacoDo";
            this.btnLacoDo.Size = new System.Drawing.Size(97, 23);
            this.btnLacoDo.TabIndex = 5;
            this.btnLacoDo.Text = "Tabuada \"DO\"";
            this.btnLacoDo.UseVisualStyleBackColor = true;
            this.btnLacoDo.Click += new System.EventHandler(this.btnLacoDo_Click);
            // 
            // btnTabuadaFor
            // 
            this.btnTabuadaFor.Location = new System.Drawing.Point(130, 192);
            this.btnTabuadaFor.Name = "btnTabuadaFor";
            this.btnTabuadaFor.Size = new System.Drawing.Size(97, 23);
            this.btnTabuadaFor.TabIndex = 6;
            this.btnTabuadaFor.Text = "Tabuada \"FOR\"";
            this.btnTabuadaFor.UseVisualStyleBackColor = true;
            this.btnTabuadaFor.Click += new System.EventHandler(this.btnTabuadaFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabuadaFor);
            this.Controls.Add(this.btnLacoDo);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstTabuada;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnLacoDo;
        private System.Windows.Forms.Button btnTabuadaFor;
    }
}

