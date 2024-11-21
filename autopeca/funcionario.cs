using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static yoshi.Properties.conn;

namespace autopeca
{
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
            // Adicionando itens na ComboBox
            comboBox1.Items.Add(new Item { Id = 1, Nome = "Vendedor" });
            comboBox1.Items.Add(new Item { Id = 2, Nome = "Gerente" });
            comboBox1.Items.Add(new Item { Id = 3, Nome = "Dono" });

            // Definindo a propriedade DisplayMember para mostrar o nome dos itens
            comboBox1.DisplayMember = "Nome";

            // Associando o evento SelectedIndexChanged
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        public class Item
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }



        private void funcionario_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = AcessoMysql.AbrirCon();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {

                string query = "SELECT * FROM `funcionario`";
                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void inserir_Click_1(object sender, EventArgs e)
        {
            // Verifique se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(nome.Text) || string.IsNullOrEmpty(cpf.Text) || string.IsNullOrEmpty(telefone.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(endereco.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifique se um item da ComboBox foi selecionado
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um item na ComboBox.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtendo o item selecionado na ComboBox
            Item itemSelecionado = (Item)comboBox1.SelectedItem;
            int idSelecionado = itemSelecionado.Id;

            MySqlConnection conn = AcessoMysql.AbrirCon();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                // Aqui é onde acontece o cadastro. Logo abaixo tem a query do banco de dados onde vai pegar todos os dados informados na tela do programa e guardar no banco
                conn.Open();
                cmd.CommandText = "Insert into funcionario (NOME, CPF, TELEFONE, EMAIL, ENDERECO, SENHA, CARGO) values (@Nome, @Cpf, @Telefone, @Email, @Endereco, @senha, @cargo)";
                cmd.Parameters.AddWithValue("@Nome", nome.Text);
                cmd.Parameters.AddWithValue("@Cpf", cpf.Text);
                cmd.Parameters.AddWithValue("@Telefone", telefone.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Endereco", endereco.Text);
                cmd.Parameters.AddWithValue("@senha", senha_txt.Text);
                cmd.Parameters.AddWithValue("@cargo", idSelecionado);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro feito com sucesso.", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   //se der certo tem essa msg de sucesso
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);                  // se der erro aqui esta o tratamento devido
            }
            try
            {
                string query = "SELECT * FROM `funcionario`";
                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void busca_Click_1(object sender, EventArgs e)
        {
            string termoBusca = nome.Text.Trim();
            int? cargoSelecionado = null;  // Variável para armazenar o cargo selecionado

            // Verifique se algum item da ComboBox foi selecionado (se sim, armazene o valor do cargo)
            if (comboBox1.SelectedItem != null)
            {
                Item itemSelecionado = (Item)comboBox1.SelectedItem;
                cargoSelecionado = itemSelecionado.Id;
            }

            MySqlConnection conn = AcessoMysql.AbrirCon();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();

                // Construa a query dinamicamente dependendo se temos um termo de busca e um cargo selecionado
                if (string.IsNullOrEmpty(termoBusca) && cargoSelecionado == null)
                {
                    // Se não houver termo de busca nem cargo selecionado, mostra todos os funcionários
                    cmd.CommandText = "SELECT * FROM funcionario";
                }
                else
                {
                    // Se houver termo de busca e/ou cargo selecionado, construa a query de acordo
                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM funcionario WHERE 1 = 1");

                    // Adicionar filtro de nome (se houver)
                    if (!string.IsNullOrEmpty(termoBusca))
                    {
                        queryBuilder.Append(" AND nome LIKE @termo");
                        cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");
                    }

                    // Adicionar filtro de cargo (se houver)
                    if (cargoSelecionado.HasValue)
                    {
                        queryBuilder.Append(" AND cargo = @cargo");
                        cmd.Parameters.AddWithValue("@cargo", cargoSelecionado.Value);
                    }

                    // Definir a query gerada
                    cmd.CommandText = queryBuilder.ToString();
                }

                // Executar a consulta
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Exibe os resultados na DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void alterar_Click_1(object sender, EventArgs e)
        {
            // Verifique se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(nome.Text) || string.IsNullOrEmpty(cpf.Text) || string.IsNullOrEmpty(telefone.Text) ||
                string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(endereco.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos, incluindo o cargo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtendo o item selecionado na ComboBox para o campo "cargo"
            Item itemSelecionado = (Item)comboBox1.SelectedItem;
            int idCargoSelecionado = itemSelecionado.Id;

            MySqlConnection conn = AcessoMysql.AbrirCon();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();

                // Atualizando a query para incluir o campo "cargo"
                cmd.CommandText = "UPDATE funcionario SET NOME = @Nome, CPF = @Cpf, TELEFONE = @Telefone, EMAIL = @Email, ENDERECO = @Endereco, SENHA = @senha, CARGO = @Cargo WHERE ID = @Id";

                // Definindo os parâmetros
                cmd.Parameters.AddWithValue("@Nome", nome.Text);
                cmd.Parameters.AddWithValue("@Cpf", cpf.Text);
                cmd.Parameters.AddWithValue("@Telefone", telefone.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Endereco", endereco.Text);
                cmd.Parameters.AddWithValue("@senha", senha_txt.Text);
                cmd.Parameters.AddWithValue("@Cargo", idCargoSelecionado);
                cmd.Parameters.AddWithValue("@Id", id.Text);  // Supondo que o 'id' seja o ID do funcionário a ser alterado

                // Executando a consulta
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Alteração feita com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Recarregando os dados na DataGridView após a alteração
            try
            {
                string query = "SELECT * FROM `funcionario`";
                cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void deletar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja continuar?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conn = AcessoMysql.AbrirCon();
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT id FROM funcionario WHERE nome = @nome";
                    cmd.Parameters.AddWithValue("@nome", nome.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null) // Se o funcionario existe
                    {
                        int clientId = Convert.ToInt32(result);
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE FROM funcionario WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", clientId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("O funcionario " + nome.Text + " foi excluído com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();

                    string query = "SELECT * FROM `funcionario`";
                    cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("A operação foi cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
