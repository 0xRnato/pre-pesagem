using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pre_pesagem
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void ListarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOS);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(dataGridView1);
        }
    }
}