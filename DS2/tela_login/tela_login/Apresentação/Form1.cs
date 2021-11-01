using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tela_login.Controle;

namespace tela_login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        // 1 hora e 18
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // IR ATÉ O BANCO DE DADOS
            // CHECAR VALIDAÇÃO DO USUARIO
            //SE POSIVITO, TELA DE BOAS VINDAS + PERFIL
            // CASEO NEGATIVO, MENSAGEM DE ERRO E NÃO ENTRAR

            Controle1 ctl = new Controle1();

            if (ctl.Acessar(txtUsuario.Text, txtSenha.Text))
            {
                MessageBox.Show("Bem vindo ao Sistema!");
            }
            else MessageBox.Show("Usuário não encontrado");
        }

       
    }
}
