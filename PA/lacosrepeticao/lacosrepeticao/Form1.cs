using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacosrepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            //Laços de Repetição -> São Estruturas que permitem que um trecho de codigo seja
            //executado por um número finito de vezes
            int numero, res, cont;
            cont = 1;
            numero = Convert.ToInt32(textBox1.Text);

            while (cont <= 99 )
            {
                res = numero + cont;
                lstTabuada.Items.Add(res.ToString());
                cont++;
            }

            

        }

        private void btnLacoDo_Click(object sender, EventArgs e)
        {
            {
                lstTabuada.Items.Clear();

                int numero, res, cont;
                cont = 1;
                numero = Convert.ToInt32(textBox1.Text);

                do
                {
                    res = numero * cont;
                    lstTabuada.Items.Add(res.ToString());
                    cont++;
                } while (cont <= 10);

            }
    
        }

        private void btnTabuadaFor_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();

            int numero, res, cont;
            numero = Convert.ToInt32(textBox1.Text);
            for (cont = 1; cont <= 10; cont++) 
            {
                res = numero * cont;
                lstTabuada.Items.Add(res.ToString());
            }
        }
    }
}

/*
 int numero, res;
            numero = Convert.ToInt32(textBox1.Text);
            res = numero * 1;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 2;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 3;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 5;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 6;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 7;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 8;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 9;
            lstTabuada.Items.Add(res.ToString());
            res = numero * 10;
            lstTabuada.Items.Add(res.ToString());

 */