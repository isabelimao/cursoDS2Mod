using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelsiusKelvin_Click(object sender, EventArgs e)
        {
            double kelvin, celsius;
            celsius = Convert.ToDouble(textCelsius.Text);
            kelvin = celsius + 273;
            MessageBox.Show(/*Essa da frente, vai dentro da caixa*/"Resultado " + kelvin + " K", "TITULO");
        }

        private void btnKelvinCelsius_Click(object sender, EventArgs e)
        {
            double kelvin, celsius;
            kelvin = Convert.ToDouble(txtkelvin.Text);
            celsius = kelvin - 273;
            MessageBox.Show("Resultado " + kelvin + " °C");
        }
    }
}
