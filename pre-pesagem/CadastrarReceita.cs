using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pre_pesagem
{
    public partial class CadastrarReceita : Form
    {
        private int id_Receita;

        public CadastrarReceita()
        {
            InitializeComponent();
        }

        private void CadastrarReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOSRECEITA' table. You can move, or remove it, as needed.
            this.pRODUTOSRECEITATableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOSRECEITA);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOSRECEITA' table. You can move, or remove it, as needed.
            this.pRODUTOSRECEITATableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOSRECEITA);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOS);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOSRECEITA' table. You can move, or remove it, as needed.
            this.rECEITATableAdapter.Fill(this._pre_pesagemDataSet.RECEITA);
            txt_Nome.Text = "";
            txt_Rendimento.Text = "";
            id_Receita = 0;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbox_Setor.SelectedItem == null)
                    throw new Exception("Selecione um setor.");
                if (txt_Nome.Text == "")
                    throw new Exception("Digite um nome para receita.");
                if (txt_Rendimento.Text == "")
                    throw new Exception("Digite o rendimento desta receita.");
                int member;
                if (!int.TryParse(txt_Rendimento.Text, out member))
                    throw new Exception("Digite um valor numérico e inteiro para indicar o rendimento da receita.");

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO RECEITA (SETOR,NOME,RENDIMENTO) VALUES(@SETOR,@NOME,@RENDIMENTO)SELECT SCOPE_IDENTITY()", connection);
                command.Parameters.AddWithValue("@SETOR", cbox_Setor.SelectedItem);
                command.Parameters.AddWithValue("@NOME", txt_Nome.Text);
                command.Parameters.AddWithValue("@RENDIMENTO", txt_Rendimento.Text);
                connection.Open();
                id_Receita = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                gbox_Produtos.Visible = true;
                gbox_Receita.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbox_Produto.SelectedItem == null)
                    throw new Exception("Selecione um produto.");
                if (txt_Quantidade.Text == "")
                    throw new Exception("Digite a quantidade do produto.");
                if (txt_Quantidade.Text.Contains(","))
                    throw new Exception("O campo VALOR deve ser preenchido com '.' para separação de casas decimais!");

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO PRODUTOSRECEITA (ID_PRODUTO,QUANTIDADE,ID_RECEITA) VALUES(@ID_PRODUTO,@QUANTIDADE,@ID_RECEITA)", connection);
                SqlCommand selectProdutosReceita = new SqlCommand("SELECT ID_PRODUTO, QUANTIDADE FROM PRODUTOSRECEITA WHERE ID_RECEITA=@ID_RECEITA;", connection);
                SqlCommand selectProdutos = new SqlCommand("SELECT NOME,UNIDADE FROM PRODUTOS WHERE ID=@ID;", connection);
                SqlDataReader readerProdutosReceita, readerProdutos;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGrid);

                command.Parameters.AddWithValue("@ID_PRODUTO", cbox_Produto.SelectedValue);
                command.Parameters.AddWithValue("@QUANTIDADE", txt_Quantidade.Text);
                command.Parameters.AddWithValue("@ID_RECEITA", id_Receita);

                selectProdutos.Parameters.AddWithValue("@ID", cbox_Produto.SelectedValue);
                selectProdutosReceita.Parameters.AddWithValue("@ID_RECEITA", id_Receita);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                readerProdutos = selectProdutos.ExecuteReader();
                while (readerProdutos.Read())
                {
                    IDataReader tmp = readerProdutos;
                    row.Cells[1].Value = tmp[0];
                    row.Cells[3].Value = tmp[1];
                }
                readerProdutos.Close();


                readerProdutosReceita = selectProdutosReceita.ExecuteReader();
                while (readerProdutosReceita.Read())
                {
                    IDataReader tmp = readerProdutosReceita;
                    row.Cells[0].Value = tmp[0];
                    row.Cells[2].Value = tmp[1];
                }
                readerProdutosReceita.Close();

                connection.Close();
                dataGrid.Rows.Add(row);
                txt_Quantidade.Text = "";
                cbox_Produto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
