using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pre_pesagem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto form = new CadastrarProduto();
            form.ShowDialog();
        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProdutos form = new ListarProdutos();
            form.ShowDialog();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProduto form = new EditarProduto();
            form.ShowDialog();
        }

        private void cadastrarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReceita form = new CadastrarReceita();
            form.ShowDialog();
        }

        private void listarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarReceitas form = new ListarReceitas();
            form.ShowDialog();
        }

        private void editarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarReceita form = new EditarReceita();
            form.ShowDialog();
        }
    }
}
