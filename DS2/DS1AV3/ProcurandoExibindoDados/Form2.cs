using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProcurandoExibindoDados
{
    public partial class Form2 : Form
    {
        //ARRUMAR ALGUMAS COISAS AQUI
        string strconn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerCadastro"].ConnectionString;

        //declara um dataset privado que armazena os detalhes 
        //que serão armazenados no dataset public dsGetDetalhes 
        private DataSet dsDetalhesClientes;

        public DataSet dsGetDetalhes
        {
            get
            {
                return dsDetalhesClientes;
            }
            set
            {
                dsDetalhesClientes = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetClientesForm1(); //chama a função
        }

        private void GetClientesForm1() //exibe detalhes dos clientes
        {
            try
            {
                txtID.Text = dsDetalhesClientes.Tables[0].Rows[0]["id"].ToString();
                txtNome.Text = dsDetalhesClientes.Tables[0].Rows[0]["nome"].ToString();
                txtEndereco.Text = dsDetalhesClientes.Tables[0].Rows[0]["endereco"].ToString();
                txtTelefone.Text = dsDetalhesClientes.Tables[0].Rows[0]["telefone"].ToString();
                txtEmail.Text = dsDetalhesClientes.Tables[0].Rows[0]["email"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtID.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
                try
                {

                    SqlConnection sqlconn = new SqlConnection(strconn);
                    sqlconn.Open();
                    SqlCommand cmdInsereCliente = new SqlCommand("inserirCliente", sqlconn);
                    cmdInsereCliente.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmdInsereCliente);
                    DataSet dsClientes = new DataSet();

                    da.SelectCommand.Parameters.AddWithValue("@NOME", SqlDbType.VarChar).Value = txtNome.Text.Trim();
                    da.SelectCommand.Parameters.AddWithValue("@ENDERECO", SqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                    da.SelectCommand.Parameters.AddWithValue("@TELEFONE", SqlDbType.VarChar).Value = txtTelefone.Text.Trim();
                    da.SelectCommand.Parameters.AddWithValue("@EMAIL", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                da.SelectCommand.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = txtID.Text.Trim();

                da.Fill(dsClientes);

                    MessageBox.Show("Cliente inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection sqlconn = new SqlConnection(strconn);
                sqlconn.Open();
                SqlCommand cmdAtualizarCliente2 = new SqlCommand("AtualizarCliente2", sqlconn);
                cmdAtualizarCliente2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdAtualizarCliente2);
                DataSet dsClientes = new DataSet();

                da.SelectCommand.Parameters.AddWithValue("@NOME", SqlDbType.VarChar).Value = txtNome.Text.Trim();
                da.SelectCommand.Parameters.AddWithValue("@ENDERECO", SqlDbType.VarChar).Value = txtEndereco.Text.Trim();
                da.SelectCommand.Parameters.AddWithValue("@TELEFONE", SqlDbType.VarChar).Value = txtTelefone.Text.Trim();
                da.SelectCommand.Parameters.AddWithValue("@EMAIL", SqlDbType.VarChar).Value = txtEmail.Text.Trim();
                da.SelectCommand.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = txtID.Text.Trim();

                da.Fill(dsClientes);

                MessageBox.Show("Cliente Atualizado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlconn = new SqlConnection(strconn);
                sqlconn.Open();
                SqlCommand cmdExcluirCliente = new SqlCommand("ExcluirCliente", sqlconn);
                cmdExcluirCliente.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdExcluirCliente);
                DataSet dsClientes = new DataSet();

                
                da.SelectCommand.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = txtID.Text.Trim();
                da.Fill(dsClientes);

                MessageBox.Show("Cliente Excluído com sucesso com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Clear();
                txtNome.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}