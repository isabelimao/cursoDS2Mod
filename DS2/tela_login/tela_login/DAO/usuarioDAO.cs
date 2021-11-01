using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tela_login.DAO
{
    class usuarioDAO
    {
        public bool temAcesso = false;
        SqlCommand cmd = new SqlCommand();
        Conexao conecta = new Conexao();
        public String mensagem = "";
        public  bool VerificarLogin(String email, String senha)
        {
            cmd.CommandText = "select * from usuario where email = '"+email+ "' and senha = '" + senha+"'";
            cmd.Connection = conecta.Conectar();
            
            try
            {
                SqlDataReader dados = cmd.ExecuteReader();
                temAcesso = dados.HasRows;
            }
            catch (SqlException e)
            {
                mensagem = e.Message;
            }
            finally
            {
                conecta.desconectar();
            }
            return temAcesso;
        }

    }
}
