using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armazem
{
    public partial class Form1 : Form
    {
        SqlConnection conexaoBancoDados = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Armazem;");
        SqlCommand comandosSql;
        SqlDataAdapter adaptadorSql;
        int ProdutoId = 0;

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void ExibirDados()
        {
            try
            {
                conexaoBancoDados.Open();
                const string selectQuery = "SELECT * FROM Produtos";
                DataTable dataTable = new DataTable();
                adaptadorSql = new SqlDataAdapter(selectQuery, conexaoBancoDados);
                adaptadorSql.Fill(dataTable);
                dadosProdutos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conexaoBancoDados.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtProdutoId.Text != "" && txtNome.Text != "" && txtMarca.Text != "" && txtQuantidade.Text != "" && txtPreco.Text != "" && txtPeso.Text != "" && txtSetor.Text != "")
                {
                    InserirDados();
                }

                else
                    MessageBox.Show("Informe todos os dados", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conexaoBancoDados.Close();
                ExibirDados();
            }
        }

        private void InserirDados()
        {
            const string insertQuery = "INSERT INTO Produtos(ProdutoId,Nome,Marca,Quantidade,Preco,Peso,Setor) VALUES(@ProdutoId,@Nome,@Marca,@Quantidade,@Preco,@Peso,@Setor)";

            
            comandosSql = new SqlCommand(insertQuery, conexaoBancoDados);
            conexaoBancoDados.Open();

            comandosSql.Parameters.AddWithValue("@ProdutoId", txtProdutoId.Text);
            comandosSql.Parameters.AddWithValue("@Nome", txtNome.Text);
            comandosSql.Parameters.AddWithValue("@Marca", txtMarca.Text);
            comandosSql.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));
            comandosSql.Parameters.AddWithValue("@Preco", float.Parse(txtPreco.Text));
            comandosSql.Parameters.AddWithValue("@Peso", float.Parse(txtPeso.Text));
            comandosSql.Parameters.AddWithValue("@Setor", txtSetor.Text);
            comandosSql.ExecuteNonQuery();

            MessageBox.Show("Registro inserido com sucesso", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "" && txtMarca.Text != "" && txtQuantidade.Text != "" && txtPreco.Text != "" && txtPeso.Text != "" && txtSetor.Text != "")
                {
                    AtualizarDados();
                }

                else
                    MessageBox.Show("Informe todos os dados", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conexaoBancoDados.Close();
                ExibirDados();
            }
        }

        private void AtualizarDados()
        {
            const string updateQuery = "UPDATE Produtos SET Nome=@Nome, Marca=@Marca, Quantidade=@Quantidade, Preco=@Preco, Peso=@Peso, Setor=@Setor WHERE ProdutoId=@ProdutoId";

            comandosSql = new SqlCommand(updateQuery, conexaoBancoDados);
            conexaoBancoDados.Open();
            comandosSql.Parameters.AddWithValue("@ProdutoId", ProdutoId);
            comandosSql.Parameters.AddWithValue("@Nome", txtNome.Text);
            comandosSql.Parameters.AddWithValue("@Marca", txtMarca.Text);
            comandosSql.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));
            comandosSql.Parameters.AddWithValue("@Preco", float.Parse(txtPreco.Text));
            comandosSql.Parameters.AddWithValue("@Peso", float.Parse(txtPeso.Text));
            comandosSql.Parameters.AddWithValue("@Setor", txtSetor.Text);
            comandosSql.ExecuteNonQuery();

            MessageBox.Show("Registro atualizado com sucesso", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dadosProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdutoId = int.Parse(dadosProdutos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dadosProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarca.Text = dadosProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantidade.Text = dadosProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPreco.Text = dadosProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPeso.Text = dadosProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSetor.Text = dadosProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdutoId != 0)
                {
                    if (MessageBox.Show("Deseja excluir esse registro ?", "Armazem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ExcluirDados();
                    }
                }

                else
                    MessageBox.Show("Selecione um registro", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conexaoBancoDados.Close();
                ExibirDados();
            }
        }

        private void ExcluirDados()
        {
            const string deleteQuery = "DELETE FROM Produtos WHERE ProdutoId=@ProdutoId";
            comandosSql = new SqlCommand(deleteQuery, conexaoBancoDados);
            conexaoBancoDados.Open();
            comandosSql.Parameters.AddWithValue("@ProdutoId", ProdutoId);
            comandosSql.ExecuteNonQuery();
            MessageBox.Show("Registro excluído com sucesso", "Armazém", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
