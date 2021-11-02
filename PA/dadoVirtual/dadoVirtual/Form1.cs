using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadoVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            Random dado = new Random(); //Randomico é o que pega algo aleatóriamente
            int valor;
            valor = dado.Next(1, 4); // Retorna um randomico entre o valor minimo e até o valor máximo menos 1

            switch (valor)
            {
                case 1:
                    pctDado1.Load("/../../resources/1.png");
                    break;
                case 2:
                    pctDado1.Load("/../../resources/2.png");
                    break;
                case 3:
                    pctDado1.Load("/../../resources/3.png");
                    break;
                default:
                    break;
            }

        }
    }
}
