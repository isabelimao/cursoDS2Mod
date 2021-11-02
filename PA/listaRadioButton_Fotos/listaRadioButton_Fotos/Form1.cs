using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaRadioButton_Fotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnHerois_CheckedChanged(object sender, EventArgs e)
        {
            rbtnChapolin.Visible = true;
            rbtnSuperSam.Visible = true;
            pctChapolin.Visible = true;
            pctSam.Visible = true;
            // Vilões abaixo
            rbtnQuaseNada.Visible = false;
            rbtnPoucasTrancas.Visible = false;
            pctQuaseNada.Visible = false;
            pctPoucasTrancas.Visible = false;
        }

        private void rbtnViloes_CheckedChanged(object sender, EventArgs e)
        {
            rbtnChapolin.Visible = false;
            rbtnSuperSam.Visible = false;
            pctChapolin.Visible = false;
            pctSam.Visible = false;
            // Vilões abaixo
            rbtnQuaseNada.Visible = true;
            rbtnPoucasTrancas.Visible = true;
            pctQuaseNada.Visible = true;
            pctPoucasTrancas.Visible = true;
        }

        private void rbtnQuaseNada_CheckedChanged(object sender, EventArgs e)
        {
            rbtnPoucasTrancas.Visible = false;
            pctPoucasTrancas.Visible = false;
            lblLegenda.Visible = true;

            lblLegenda.Text = "Interpretado por Carlos Villagrán, Quase Nada é um dos membros mais clássicos da \n " +
                "gangue de Tripa Seca, mas, mesmo assim, eles sabem que não podem confiar um no outro. Este é o: " + rbtnQuaseNada.Text;
        }

        private void rbtnPoucasTrancas_CheckedChanged(object sender, EventArgs e)
        {
            rbtnQuaseNada.Visible = false;
            pctQuaseNada.Visible = false;
            lblLegenda.Visible = true;

            lblLegenda.Text = "Apesar de muita gente se lembrar de Poucas Trancas como um dos vilões \n " +
                "clássicos do Chapolin Colorado, o malfeitor só apareceu em dois episódios da série. Este é o: " + rbtnPoucasTrancas.Text; 
        }

        private void rbtnChapolin_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSuperSam.Visible = false;
            pctSam.Visible = false;
            lblLegenda.Visible = true;

            lblLegenda.Text = "Este super herói é raro, seus super poderes e qualidades são diferentes de os dos outros heróis, mas consegue superar as suas deficiências \n e superar seus problemas, aí reside a grandeza do ser humano. Este é o: " + rbtnChapolin.Text;
        }

        private void rbtnSuperSam_CheckedChanged(object sender, EventArgs e)
        {
            rbtnChapolin.Visible = false;
            pctChapolin.Visible = false;
            lblLegenda.Visible = true;

            lblLegenda.Text = " Uma caricata fusão do Superman e do Tio Sam, Super Sam é um\n super-herói americano, que fala enrolado e se importa muito com dinheiro. Este é o: " + rbtnSuperSam.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rbtnQuaseNada.Visible = false;
            rbtnPoucasTrancas.Visible = false;
            pctQuaseNada.Visible = false;
            pctPoucasTrancas.Visible = false;
            rbtnChapolin.Visible = false;
            rbtnSuperSam.Visible = false;
            pctChapolin.Visible = false;
            pctSam.Visible = false;
            lblLegenda.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
