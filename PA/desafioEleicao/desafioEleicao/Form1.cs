using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace desafioEleicao
{
    public partial class escolher_restaurante : Form
    {
        public escolher_restaurante()
        {
            InitializeComponent();
        } double voto, res;

        private void ZerarVoto()
        {
            voto = voto * 0;
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar)
               == true)
            {
                e.Handled = true;
            }
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            int voto;
            voto = Convert.ToInt32(Interaction.InputBox("QUANTAS VEZES COMEU NO RESTAURANTE?","ALGO AQUI","0"));
            if (voto < 10)
            {
                while ((voto < 10 && voto >= 0) || voto < -2) // VOTO MENOR QUE 10
                {
                    int  somaVoto;
                    somaVoto = 0;
                    res = somaVoto + 1;
                    lblSomaVoto1.Text = Convert.ToString(Convert.ToInt32(lblSomaVoto1.Text) + (res));
                    lblSomarTudo.Text = Convert.ToString(Convert.ToInt32(lblSomarTudo.Text) + (res));
                    ZerarVoto();
                    break;
                }
            } else if (voto < 10 || voto < 15) // VOTO ENTRE 11 E 15
            {
                int  somaVoto;
                somaVoto = 0;
                res = somaVoto + 1;
                lblSomaVoto2.Text = Convert.ToString(Convert.ToInt32(lblSomaVoto2.Text) + (res));
                lblSomarTudo.Text = Convert.ToString(Convert.ToInt32(lblSomarTudo.Text) + (res));
                ZerarVoto();
            }
            while (voto > 16) // VOTO ACIMA DE 16
            {
                int  somaVoto;
                somaVoto = 0;
                res = somaVoto + 1;
                lblSomaVoto3.Text = Convert.ToString(Convert.ToInt32(lblSomaVoto3.Text) + (res));
                lblSomarTudo.Text = Convert.ToString(Convert.ToInt32(lblSomarTudo.Text) + (res));
                ZerarVoto();                
                break;
            }

            // CONTAR AS PORCENTAGENS
                if (voto == -1)
            {
                double pct1, pct2, pct3, constante;
                constante = 100;
                pct1 = Convert.ToDouble(lblSomaVoto1.Text) / Convert.ToDouble(lblSomarTudo.Text);
                pct2 = Convert.ToDouble(lblSomaVoto2.Text) / Convert.ToDouble(lblSomarTudo.Text);
                pct3 = Convert.ToDouble(lblSomaVoto3.Text) / Convert.ToDouble(lblSomarTudo.Text);

                MessageBox.Show("Menos que 10 " + (pct1 * constante) + "\n Entre 11 e 15 " +  (pct2 * constante) + " \n Mais que 16 " +(pct3 * constante ));
            }
                
        }

        private void escolher_restaurante_Load(object sender, EventArgs e)
        {
            lblSomaVoto1.Text = 0.ToString();
            lblSomaVoto2.Text = 0.ToString();
            lblSomaVoto3.Text = 0.ToString();
            lblSomarTudo.Text = 0.ToString();
        }

        

    }
}


