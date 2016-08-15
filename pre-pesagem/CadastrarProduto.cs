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
            try
            {
                if (txt_Nome.Text == "" || txt_Nome.Text == null || txt_Nome.Text == string.Empty || txt_Nome.Text.Length > 50)
                    throw new Exception("O campo NOME não está preenchido corretamente.");
                if (txt_Unidade.Text == "" || txt_Unidade.Text == null || txt_Unidade.Text == string.Empty || txt_Unidade.Text.Length > 4)
                    throw new Exception("O campo UNIDADE não está preenchido corretamente.");
                if (txt_Valor.Text == "" || txt_Valor.Text == null || txt_Valor.Text == string.Empty || txt_Valor.Text.Length > 7)
                    throw new Exception("O campo NOME não está preenchido corretamente.");

                if (txt_Valor.Text.Contains(","))
                    throw new Exception("O campo VALOR deve ser preenchido com '.' para separação de casas decimais!");

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pre-pesagem.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand("INSERT INTO PRODUTOS(NOME,UNIDADE,VALOR) VALUES (@NOME,@UNIDADE,@VALOR)", connection);
                command.Parameters.AddWithValue("@NOME", txt_Nome.Text);
                command.Parameters.AddWithValue("@UNIDADE", txt_Unidade.Text);
                command.Parameters.AddWithValue("@VALOR", decimal.Parse(txt_Valor.Text));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Produto cadastrado com sucesso!");
                txt_Nome.Text = "";
                txt_Unidade.Text = "";
                txt_Valor.Text = "";
                txt_Nome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
