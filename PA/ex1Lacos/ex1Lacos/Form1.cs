using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double res=0, cont=1;
           
            while (cont <= 100)
            {
                res = res + cont;
                cont++;
            }
            MessageBox.Show(res.ToString());
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double res = 0, cont = 1;

            do
            {
                res = res + cont;
                cont++;
            } while (cont <= 100);
            MessageBox.Show(res.ToString());
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double res = 0, cont;

            for (cont=1;cont<=100;cont++)
            {
                res = res + cont;
            } 
            MessageBox.Show(res.ToString());
        }
    }
}
