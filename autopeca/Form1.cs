using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace autopeca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string nome = txtUsername.Text;  // Nome de usuário inserido
            string senha = txtPassword.Text; // Senha inserida

            // Abrindo a conexão com o banco de dados
            MySqlConnection conn = yoshi.Properties.conn.AcessoMysql.AbrirCon();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;  // Associando o comando à conexão

            try
            {
                conn.Open();  // Abrir a conexão

                // Alterando a consulta para selecionar o cargo também
                string query = "SELECT cargo FROM funcionario WHERE nome = @Nome AND senha = @Senha";
                cmd.CommandText = query;  // Definindo a consulta SQL

                // Adicionando os parâmetros para a consulta
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Senha", senha);

                // Executando a consulta e verificando o resultado
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())  // Verificando se encontrou o usuário
                {
                    // Garantindo que o valor de 'cargo' seja lido corretamente como inteiro
                    int cargo = reader.IsDBNull(reader.GetOrdinal("cargo")) ? 0 : Convert.ToInt32(reader["cargo"]);

                    if (cargo == 3)
                    {
                        MessageBox.Show("Login bem-sucedido! Bem-vindo, Dono.");
                        funcionario funcionarioForm = new funcionario();
                        funcionarioForm.ShowDialog(); // Abre o painel de "Dono"
                        this.Close();  // Fecha o formulário de login
                    }

                    else if (cargo == 2)
                    {
                        MessageBox.Show("Login bem-sucedido! Bem-vindo, Gerente.");
                        // Redirecionar para o painel de Gerente
                        funcionario funcionario = new funcionario();
                        funcionario.ShowDialog();
                    }
                    else if (cargo == 1)
                    {
                        MessageBox.Show("Login bem-sucedido! Bem-vindo, Funcionário.");
                        // Redirecionar para o painel de Funcionário
                    }
                    else
                    {
                        MessageBox.Show("Cargo não reconhecido.");
                    }
                }
                else
                {
                    MessageBox.Show("Nome ou senha inválidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                // Fechando a conexão, garantindo que os recursos sejam liberados
                conn.Close();
            }
        }
    }
}
