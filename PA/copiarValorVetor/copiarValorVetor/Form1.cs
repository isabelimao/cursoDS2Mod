using System;
using System.Windows.Forms;

namespace copiarValorVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(txtInserir.Text);

            int[] arr_sample = new int[n];
            

            for (int index = 0; index <= n; index++)
            {
                arr_sample[index] = index;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, soma;
            n1 = Convert.ToInt32(txtV1.Text);
            n2 = Convert.ToInt32(txtV2.Text);
            int[] vet1 = new int[n1];
            int[] vet2 = new int[n2];
             

            soma = vet1[n1] + vet2[n2];
            MessageBox.Show("" + soma); 

        }
    }
}
