using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace exVetoresPa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            double[] a = new double[15];
            double[] b = new double[15];
            int cont = 0;

            //ENTRADAS  (Coloco o menos 1 pq o indice é 14)
            for (cont = 0; cont <= a.Length - 1; cont++)
            {
                a[cont] = Convert.ToDouble(Interaction.InputBox("Digite um número"));
                b[cont] = Math.Pow(a[cont], 2);
                lstQuadrado.Items.Add(b[cont].ToString());
            }

            for (cont = 0; cont <= a.Length; cont++)
            {
                lstQuadrado.Items.Add(b[cont].ToString());
            }
        }
    }
}
