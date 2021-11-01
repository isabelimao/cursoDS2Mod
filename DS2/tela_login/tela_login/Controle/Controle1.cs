using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tela_login.DAO;


namespace tela_login.Controle
{
    class Controle1
    {
        private bool temAcesso = false;

        public bool Acessar(String email, String senha)
        {
            usuarioDAO usuario = new usuarioDAO();
            temAcesso = usuario.VerificarLogin(email, senha);
            return temAcesso;
        }
    }
}
