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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand("INSERT INTO PRODUTOS(NOME,UNIDADE,VALOR) VALUES (@NOME,@UNIDADE,@VALOR)", connection);
            command.Parameters.AddWithValue("@NOME", txt_Nome.Text);
            command.Parameters.AddWithValue("@UNIDADE", txt_Unidade.Text);
            command.Parameters.AddWithValue("@VALOR", decimal.Parse(txt_Valor.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Hide();
        }
    }
}
