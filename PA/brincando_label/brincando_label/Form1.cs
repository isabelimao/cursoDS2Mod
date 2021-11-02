using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brincando_label
{
    public partial class mudarNomes : Form
    {
        public mudarNomes()
        {
            InitializeComponent();
        }

        private void nomeMetodo()
        {
            // ESCREVO MEUS CODIGOS AQUI DENTRO
        }
        private void resetar() //aqui está o meu método
        {
            lbl1.Text = "Isso".ToString();
            lbl2.Text = "aqui".ToString();
            lbl3.Text = "vai".ToString();
            lbl4.Text = "mudar!".ToString();
        }

        private void mudarNomes_Load(object sender, EventArgs e) //ESSE É O INICIO DO FORM
        { //Isso ocorre quando o forms carrega
            lbl1.Text = "Isso".ToString();
            lbl2.Text = "aqui".ToString();
            lbl3.Text = "vai".ToString();
            lbl4.Text = "mudar!".ToString();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        { //Ele muda o que está escrito nas labels.
            lbl1.Text = "Agora".ToString();
            lbl2.Text = "tudo".ToString();
            lbl3.Text = "aqui".ToString();
            lbl4.Text = "mudou!".ToString();
        }

        private void btnAparecer_Click(object sender, EventArgs e)
        { //Agora eu falo se a label aparece ou não

            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

       
        private void btnApagarLbl_Click(object sender, EventArgs e)
        { //Agora eu falo se a label aparece ou não
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            resetar(); // Isso são métodos.
        }

         private void btnResetar_Click(object sender, EventArgs e)
        {
            resetar();
        }

        
    }
}
