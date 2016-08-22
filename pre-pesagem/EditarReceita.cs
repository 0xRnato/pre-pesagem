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
    public partial class EditarReceita : Form
    {
        private int id_Receita;

        public EditarReceita()
        {
            InitializeComponent();
        }

        private void EditarReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOS);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOSRECEITA' table. You can move, or remove it, as needed.
            this.pRODUTOSRECEITATableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOSRECEITA);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.RECEITA' table. You can move, or remove it, as needed.
            this.rECEITATableAdapter.Fill(this._pre_pesagemDataSet.RECEITA);
            id_Receita = (cbox_Receitas.SelectedItem == null) ? 1 : Convert.ToInt32(cbox_Receitas.SelectedValue);
            UpdateDataGrid(id_Receita);
            UpdateListBox(id_Receita);
        }

        private void UpdateListBox(int id_Receita)
        {
            lbox_Produtos.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand query = new SqlCommand("SELECT PRODUTOS.NOME,PRODUTOSRECEITA.QUANTIDADE, PRODUTOS.UNIDADE, PRODUTOSRECEITA.ID FROM PRODUTOS INNER JOIN PRODUTOSRECEITA ON PRODUTOS.ID=PRODUTOSRECEITA.ID_PRODUTO WHERE PRODUTOSRECEITA.ID_RECEITA=@ID_RECEITA;", connection);
            query.Parameters.AddWithValue("ID_RECEITA", id_Receita);
            connection.Open();
            SqlDataReader reader = query.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var item = reader.GetInt32(3) +": "+ reader.GetString(0) + " - " + reader.GetDouble(1) + " " + reader.GetString(2);
                    lbox_Produtos.Items.Add(item);
                }
            }
            else
                MessageBox.Show("No rows found");
            reader.Close();
            connection.Close();
        }

        private void UpdateDataGrid(int id_Receita)
        {
            dataGrid.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand query = new SqlCommand("SELECT PRODUTOSRECEITA.ID_PRODUTO, PRODUTOS.NOME, PRODUTOSRECEITA.QUANTIDADE, PRODUTOS.UNIDADE FROM PRODUTOSRECEITA INNER JOIN PRODUTOS ON PRODUTOSRECEITA.ID_PRODUTO=PRODUTOS.ID WHERE PRODUTOSRECEITA.ID_RECEITA=@ID_RECEITA;", connection);
            query.Parameters.AddWithValue("@ID_RECEITA", cbox_Receitas.SelectedValue);
            

            connection.Open();
            SqlDataReader reader = query.ExecuteReader();

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGrid);
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetDouble(2);
                    row.Cells[3].Value = reader.GetString(3);
                    dataGrid.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No rows found.");
            }
            reader.Close();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Receita = (cbox_Receitas.SelectedItem == null) ? 1 : Convert.ToInt32(cbox_Receitas.SelectedValue);
            UpdateDataGrid(id_Receita);
            UpdateListBox(id_Receita);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lbox_Produtos.SelectedItem == null)
                MessageBox.Show("Selecione um item para remove-lo.");
            else
            {
                DialogResult dialog = MessageBox.Show("Tem certeza de que quer remover este item?", "Cuidado!!!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
                    SqlCommand command = new SqlCommand("DELETE FROM PRODUTOSRECEITA WHERE ID=@ID;", connection);
                    string[] id = lbox_Produtos.SelectedItem.ToString().Split(':');
                    command.Parameters.AddWithValue("@ID", id[0]);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    UpdateDataGrid(id_Receita);
                    UpdateListBox(id_Receita);
                    MessageBox.Show("DELETADO!!!");
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand("INSERT INTO PRODUTOSRECEITA (ID_PRODUTO,QUANTIDADE,ID_RECEITA) VALUES(@ID_PRODUTO,@QUANTIDADE,@ID_RECEITA)", connection);
            command.Parameters.AddWithValue("@ID_PRODUTO", cbox_Produto.SelectedValue);
            command.Parameters.AddWithValue("@QUANTIDADE", txt_Quantidade.Text);
            command.Parameters.AddWithValue("@ID_RECEITA", id_Receita);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            UpdateDataGrid(id_Receita);
            UpdateListBox(id_Receita);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem certeza de que quer remover este item?", "Cuidado!!!", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand("DELETE FROM RECEITA WHERE ID=@ID_RECEITA;", connection);
                SqlCommand command2 = new SqlCommand("DELETE FROM PRODUTOSRECEITA WHERE ID_RECEITA=@ID_RECEITA;", connection);
                command.Parameters.AddWithValue("@ID_RECEITA", id_Receita);
                command2.Parameters.AddWithValue("@ID_RECEITA", id_Receita);
                connection.Open();
                command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Receita deletada.");
                Hide();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {//CONTINUAR AQUI..
            string[,] matrizDataGrid = new string[dataGrid.RowCount - 1, dataGrid.ColumnCount - 1];
            for (int i = 0; i < matrizDataGrid.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDataGrid.GetLength(1); j++)
                {
                    matrizDataGrid[i, j] = dataGrid[i, j].Value.ToString();
                }
            }


            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand("UPDATE RECEITA SET SETOR=@SETOR, NOME=@NOME, RENDIMENTO=@RENDIMENTO WHERE ID=@ID;", connection);
            SqlCommand command2 = new SqlCommand("UPDATE PRODUTOSRECEITA SET ID_PRODUTO=@ID_PRODUTO, QUANTIDADE=@QUANTIDADE WHERE ID=@ID;", connection);
            command.Parameters.AddWithValue("@ID", id_Receita);
            command.Parameters.AddWithValue("@SETOR", cbox_Setor.SelectedItem);
            command.Parameters.AddWithValue("@NOME", txt_Nome.Text);
            command.Parameters.AddWithValue("@RENDIMENTO", txt_Rendimento.Text);
            //command2.Parameters.AddWithValue("@ID_PRODUTO",)
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            UpdateDataGrid(id_Receita);
            UpdateListBox(id_Receita);
            MessageBox.Show("As alterações foram salvas.");
            Hide();
        }
    }
}
