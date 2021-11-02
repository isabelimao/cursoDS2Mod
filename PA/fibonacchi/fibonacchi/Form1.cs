using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
                   == true)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnTermo_Click(object sender, EventArgs e)
        {
            int termo, x, y, z;
            x = 1;
            y = 0;
            z = 0;
            termo = Convert.ToInt32(txtNm1.Text);

            for (int i = 0; i < termo; i++)
            {
                z = x + y;
                listDigitosFb.Items.Add(z.ToString());
                y = x;
                x = z;
            }
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listDigitosFb.Items.Clear();
            txtNm1.Clear();
            txtNm1.Focus();
        }
    }
}
        