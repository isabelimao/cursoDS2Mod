using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace tela_login.DAO
{
    class Conexao
    {
        private SqlConnection conecta = new SqlConnection();

        public Conexao()
        {
            this.conecta.ConnectionString = "Data Source=J-PC/SQLEXPRESS;Initial Catalog=DS1AV4;Integrated Security=True";
            // estou em uma hora e 4 do video
        }
        
        public SqlConnection Conectar()
        {
            if (conecta.State == System.Data.ConnectionState.Closed)conecta.Open();
            return conecta;
        }

        public void desconectar()
        {
            if (conecta.State == System.Data.ConnectionState.Open) conecta.Close();
        }
    }
}
