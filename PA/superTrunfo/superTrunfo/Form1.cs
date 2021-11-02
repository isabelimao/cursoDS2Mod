using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superTrunfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random jogada = new Random(); //Randomico é o que pega algo aleatóriamente
            int valor;
            valor = jogada.Next(1, 4); // Retorna um randomico entre o valor minimo e até o va

            Random cpu = new Random(); //CPU
            int valorcpu;
            valorcpu = cpu.Next(1, 4); 

            switch (valor)
            {
                case 1:
                    pctUsuario.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/chunli.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1] );
                    } else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    } else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    
                    return;

                case 2:
                    pctUsuario.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/ryu.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;

                case 3:
                    pctUsuario.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/ken.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;

                case 4:
                    pctUsuario.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/zangief.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;
                default:
                    break;
            }

            switch (valorcpu)
            {
                case 1:
                    pctPc.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/chunli.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "50", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }

                    return;

                case 2:
                    pctPc.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/ryu.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;

                case 3:
                    pctPc.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/ken.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "70", "80", "45" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;

                case 4:
                    pctPc.Load("C:/Users/J/source/repos/superTrunfo/superTrunfo/Resources/zangief.jpg");
                    if (rbtnAtaqueUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Ataque " + carta1[1]);
                    }
                    else if (rbtnDefesaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Defesa " + carta1[2]);
                    }
                    else if (rbtnMagiaUsuario.Checked == true)
                    {
                        string[] carta1 = new string[4] { "0", "100", "80", "10" };
                        MessageBox.Show("Escolheu Magia " + carta1[3]);
                    }
                    return;
                default:
                    break;
            }
            if (valor > valorcpu)
            {
                MessageBox.Show("1");
            }
        }
    }
}
