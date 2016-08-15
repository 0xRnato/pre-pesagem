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
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOS);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand("UPDATE PRODUTOS SET NOME=@NOME,UNIDADE=@UNIDADE,VALOR=@VALOR WHERE ID=@ID", connection);
            command.Parameters.AddWithValue("@NOME", txt_NOME.Text);
            command.Parameters.AddWithValue("@UNIDADE", txt_UNIDADE.Text);
            command.Parameters.AddWithValue("@VALOR", decimal.Parse(txt_VALOR.Text));
            command.Parameters.AddWithValue("@ID", int.Parse(box_Produtos.SelectedValue.ToString()));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand("DELETE FROM PRODUTOS WHERE ID=@ID", connection);
            command.Parameters.AddWithValue("@ID", int.Parse(box_Produtos.SelectedValue.ToString()));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Hide();
        }
    }
}
