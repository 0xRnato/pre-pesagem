using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pre_pesagem
{
    public partial class ListarReceitas : Form
    {
        public ListarReceitas()
        {
            InitializeComponent();
        }

        private void rECEITABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rECEITABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._pre_pesagemDataSet);

        }

        private void ListarReceitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.PRODUTOSRECEITA' table. You can move, or remove it, as needed.
            this.pRODUTOSRECEITATableAdapter.Fill(this._pre_pesagemDataSet.PRODUTOSRECEITA);
            // TODO: This line of code loads data into the '_pre_pesagemDataSet.RECEITA' table. You can move, or remove it, as needed.
            this.rECEITATableAdapter.Fill(this._pre_pesagemDataSet.RECEITA);

        }
    }
}
