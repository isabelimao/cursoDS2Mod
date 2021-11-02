using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ler_1ate12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);

            while (num < 1 || num > 12)
            {
                MessageBox.Show("Digite um valor válido");
                return;
            }

            switch (num)
            {
                case 1:
                    MessageBox.Show("Mês de Janeiro");
                    textBox1.Clear();
                    break;
                    
                case 2:
                    MessageBox.Show("Mês de Fevereiro");
                    textBox1.Clear();
                    break;
                   
                case 3:
                    MessageBox.Show("Mês de Março");
                    textBox1.Clear();
                    break;
                   
                case 4:
                    MessageBox.Show("Mês de Abril");
                    textBox1.Clear();
                    break;
                  
                case 5:
                    MessageBox.Show("Mês de Maio");
                    textBox1.Clear();
                    break;
                  
                case 6:
                    MessageBox.Show("Mês de Junho");
                    textBox1.Clear();
                    break;
                
                case 7:
                    MessageBox.Show("Mês de Julho");
                    textBox1.Clear();
                    break;
               
                case 8:
                    MessageBox.Show("Mês de Agosto");
                    textBox1.Clear();
                    break;
          
                case 9:
                    MessageBox.Show("Mês de Setembro");
                    textBox1.Clear();
                    break;
              
                case 10:
                    textBox1.Clear();
                    MessageBox.Show("Mês de Outubro");
                    textBox1.Clear();
                    break;
          
                case 11:
                    MessageBox.Show("Mês de Novembro");
                    textBox1.Clear();
                    break;
                    
                case 12:
                    MessageBox.Show("Mês de Dezembro");
                    textBox1.Clear();
                    break;
                default:
                    break;
            }



        }
    }
}


/*
 [22:20] ALEX SANDER RESENDE DE DEUS
int valor;
string mes;
valor = Convert.ToInt32(txtMes.Text);
switch (valor){​​
case 1:
mes = "Janeiro";
break;
case 2:
mes = "Fevereiro";
break;
case 3:
mes = "Março";
break;
case 4:
mes = "Abril";
break;
case 5:
mes = "Maio";
break;
case 6:
mes = "Junho";
break;
case 7:
mes = "Julho";
break;
case 8:
mes = "Agosto";
break;
case 9:
mes = "Setembro";
break;
case 10:
mes = "Outubro";
break;
case 11:
mes = "Novembro";
break;
case 12:
mes = "Dezembro";
break;
default:
mes = "Mês inválido";
break;
}​​
MessageBox.Show(mes);


 
 */