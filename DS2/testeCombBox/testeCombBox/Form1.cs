using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeCombBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(cboRegiao.SelectedIndex == 0)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            } else if (cboRegiao.SelectedIndex == 1)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 2)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 3)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 4)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 5)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 6)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 7)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 8)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 9)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 11)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 12)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 13)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 14)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 15)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 16)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 17)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 18)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 19)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 20)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 21)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 22)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 23)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 24)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 25)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else if (cboRegiao.SelectedIndex == 20)
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
            else 
            {
                MessageBox.Show("Você mora em: " + (cboRegiao.SelectedItem));
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboRegiao.SelectedIndex = - 1;
        }
    }
}
