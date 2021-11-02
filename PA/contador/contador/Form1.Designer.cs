
namespace contador
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
            this.lblConversor = new System.Windows.Forms.Label();
            this.btnCelsiusFahrenheit = new System.Windows.Forms.Button();
            this.textCelsius = new System.Windows.Forms.TextBox();
            this.btnCelsiusKelvin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtkelvin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnKelvinCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(45, 112);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(204, 25);
            this.lblConversor.TabIndex = 0;
            this.lblConversor.Text = "Conversões Celsius";
            // 
            // btnCelsiusFahrenheit
            // 
            this.btnCelsiusFahrenheit.Location = new System.Drawing.Point(50, 190);
            this.btnCelsiusFahrenheit.Name = "btnCelsiusFahrenheit";
            this.btnCelsiusFahrenheit.Size = new System.Drawing.Size(84, 25);
            this.btnCelsiusFahrenheit.TabIndex = 10;
            this.btnCelsiusFahrenheit.Text = "Fahrenheit";
            this.btnCelsiusFahrenheit.UseVisualStyleBackColor = true;
            // 
            // textCelsius
            // 
            this.textCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCelsius.Location = new System.Drawing.Point(50, 140);
            this.textCelsius.Name = "textCelsius";
            this.textCelsius.Size = new System.Drawing.Size(200, 44);
            this.textCelsius.TabIndex = 11;
            // 
            // btnCelsiusKelvin
            // 
            this.btnCelsiusKelvin.Location = new System.Drawing.Point(50, 221);
            this.btnCelsiusKelvin.Name = "btnCelsiusKelvin";
            this.btnCelsiusKelvin.Size = new System.Drawing.Size(84, 25);
            this.btnCelsiusKelvin.TabIndex = 12;
            this.btnCelsiusKelvin.Text = "Kelvin";
            this.btnCelsiusKelvin.UseVisualStyleBackColor = true;
            this.btnCelsiusKelvin.Click += new System.EventHandler(this.btnCelsiusKelvin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(322, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 44);
            this.textBox2.TabIndex = 17;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(317, 112);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(236, 25);
            this.lblFahrenheit.TabIndex = 14;
            this.lblFahrenheit.Text = "Conversões Fahrenheit";
            // 
            // txtkelvin
            // 
            this.txtkelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkelvin.Location = new System.Drawing.Point(567, 140);
            this.txtkelvin.Name = "txtkelvin";
            this.txtkelvin.Size = new System.Drawing.Size(200, 44);
            this.txtkelvin.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Conversões Kelvin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 25);
            this.button2.TabIndex = 25;
            this.button2.Text = "Kelvin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 25);
            this.button3.TabIndex = 24;
            this.button3.Text = "Fahrenheit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 25);
            this.button5.TabIndex = 27;
            this.button5.Text = "Kelvin";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnKelvinCelsius
            // 
            this.btnKelvinCelsius.Location = new System.Drawing.Point(567, 190);
            this.btnKelvinCelsius.Name = "btnKelvinCelsius";
            this.btnKelvinCelsius.Size = new System.Drawing.Size(84, 25);
            this.btnKelvinCelsius.TabIndex = 26;
            this.btnKelvinCelsius.Text = "Celsius";
            this.btnKelvinCelsius.UseVisualStyleBackColor = true;
            this.btnKelvinCelsius.Click += new System.EventHandler(this.btnKelvinCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnKelvinCelsius);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtkelvin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnCelsiusKelvin);
            this.Controls.Add(this.textCelsius);
            this.Controls.Add(this.btnCelsiusFahrenheit);
            this.Controls.Add(this.lblConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.Button btnCelsiusFahrenheit;
        private System.Windows.Forms.TextBox textCelsius;
        private System.Windows.Forms.Button btnCelsiusKelvin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtkelvin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnKelvinCelsius;
    }
}

