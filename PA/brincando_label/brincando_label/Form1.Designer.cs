
namespace brincando_label
{
    partial class mudarNomes
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
            this.btnMudar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnAparecer = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnApagarLbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMudar
            // 
            this.btnMudar.Location = new System.Drawing.Point(224, 168);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(135, 46);
            this.btnMudar.TabIndex = 0;
            this.btnMudar.Text = "MUDE OS NOMES";
            this.btnMudar.UseVisualStyleBackColor = true;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(92, 103);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 22);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(210, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 22);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "label2";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(333, 103);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 22);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "label3";
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(450, 103);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(59, 22);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "label4";
            this.lbl4.Visible = false;
            // 
            // btnAparecer
            // 
            this.btnAparecer.Location = new System.Drawing.Point(95, 220);
            this.btnAparecer.Name = "btnAparecer";
            this.btnAparecer.Size = new System.Drawing.Size(102, 46);
            this.btnAparecer.TabIndex = 5;
            this.btnAparecer.Text = "Aparecer as Labels";
            this.btnAparecer.UseVisualStyleBackColor = true;
            this.btnAparecer.Click += new System.EventHandler(this.btnAparecer_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(383, 220);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(102, 46);
            this.btnResetar.TabIndex = 6;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnApagarLbl
            // 
            this.btnApagarLbl.Location = new System.Drawing.Point(240, 286);
            this.btnApagarLbl.Name = "btnApagarLbl";
            this.btnApagarLbl.Size = new System.Drawing.Size(102, 46);
            this.btnApagarLbl.TabIndex = 7;
            this.btnApagarLbl.Text = "Apagar as Labels";
            this.btnApagarLbl.UseVisualStyleBackColor = true;
            this.btnApagarLbl.Click += new System.EventHandler(this.btnApagarLbl_Click);
            // 
            // mudarNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 372);
            this.Controls.Add(this.btnApagarLbl);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnAparecer);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnMudar);
            this.Name = "mudarNomes";
            this.Text = "Mudar os Nomes";
            this.Load += new System.EventHandler(this.mudarNomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnAparecer;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnApagarLbl;
    }
}

