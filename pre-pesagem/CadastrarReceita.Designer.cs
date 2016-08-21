namespace pre_pesagem
{
    partial class CadastrarReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sETORLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label rENDIMENTOLabel;
            System.Windows.Forms.Label iD_PRODUTOLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            this.btn_Next = new System.Windows.Forms.Button();
            this.gbox_Produtos = new System.Windows.Forms.GroupBox();
            this.cbox_Produto = new System.Windows.Forms.ComboBox();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pre_pesagemDataSet = new pre_pesagem._pre_pesagemDataSet();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gbox_Receita = new System.Windows.Forms.GroupBox();
            this.cbox_Setor = new System.Windows.Forms.ComboBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Rendimento = new System.Windows.Forms.TextBox();
            this.rECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.RECEITATableAdapter();
            this.tableAdapterManager = new pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager();
            this.pRODUTOSTableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.pRODUTOSRECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSRECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            sETORLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            rENDIMENTOLabel = new System.Windows.Forms.Label();
            iD_PRODUTOLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            this.gbox_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).BeginInit();
            this.gbox_Receita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sETORLabel
            // 
            sETORLabel.AutoSize = true;
            sETORLabel.Location = new System.Drawing.Point(6, 16);
            sETORLabel.Name = "sETORLabel";
            sETORLabel.Size = new System.Drawing.Size(47, 13);
            sETORLabel.TabIndex = 12;
            sETORLabel.Text = "SETOR:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(6, 43);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 14;
            nOMELabel.Text = "NOME:";
            // 
            // rENDIMENTOLabel
            // 
            rENDIMENTOLabel.AutoSize = true;
            rENDIMENTOLabel.Location = new System.Drawing.Point(6, 69);
            rENDIMENTOLabel.Name = "rENDIMENTOLabel";
            rENDIMENTOLabel.Size = new System.Drawing.Size(83, 13);
            rENDIMENTOLabel.TabIndex = 16;
            rENDIMENTOLabel.Text = "RENDIMENTO:";
            // 
            // iD_PRODUTOLabel
            // 
            iD_PRODUTOLabel.AutoSize = true;
            iD_PRODUTOLabel.Location = new System.Drawing.Point(17, 22);
            iD_PRODUTOLabel.Name = "iD_PRODUTOLabel";
            iD_PRODUTOLabel.Size = new System.Drawing.Size(64, 13);
            iD_PRODUTOLabel.TabIndex = 18;
            iD_PRODUTOLabel.Text = "PRODUTO:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(17, 49);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(81, 13);
            qUANTIDADELabel.TabIndex = 20;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(122, 97);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Avançar";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // gbox_Produtos
            // 
            this.gbox_Produtos.Controls.Add(iD_PRODUTOLabel);
            this.gbox_Produtos.Controls.Add(this.cbox_Produto);
            this.gbox_Produtos.Controls.Add(qUANTIDADELabel);
            this.gbox_Produtos.Controls.Add(this.txt_Quantidade);
            this.gbox_Produtos.Controls.Add(this.btn_Add);
            this.gbox_Produtos.Location = new System.Drawing.Point(263, 12);
            this.gbox_Produtos.Name = "gbox_Produtos";
            this.gbox_Produtos.Size = new System.Drawing.Size(245, 127);
            this.gbox_Produtos.TabIndex = 999;
            this.gbox_Produtos.TabStop = false;
            this.gbox_Produtos.Text = "Produtos";
            this.gbox_Produtos.Visible = false;
            // 
            // cbox_Produto
            // 
            this.cbox_Produto.DataSource = this.pRODUTOSBindingSource;
            this.cbox_Produto.DisplayMember = "NOME";
            this.cbox_Produto.FormattingEnabled = true;
            this.cbox_Produto.Location = new System.Drawing.Point(104, 19);
            this.cbox_Produto.Name = "cbox_Produto";
            this.cbox_Produto.Size = new System.Drawing.Size(121, 21);
            this.cbox_Produto.TabIndex = 5;
            this.cbox_Produto.ValueMember = "ID";
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this._pre_pesagemDataSet;
            // 
            // _pre_pesagemDataSet
            // 
            this._pre_pesagemDataSet.DataSetName = "_pre_pesagemDataSet";
            this._pre_pesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(104, 46);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(121, 20);
            this.txt_Quantidade.TabIndex = 6;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(150, 78);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gbox_Receita
            // 
            this.gbox_Receita.Controls.Add(sETORLabel);
            this.gbox_Receita.Controls.Add(this.cbox_Setor);
            this.gbox_Receita.Controls.Add(nOMELabel);
            this.gbox_Receita.Controls.Add(this.txt_Nome);
            this.gbox_Receita.Controls.Add(rENDIMENTOLabel);
            this.gbox_Receita.Controls.Add(this.txt_Rendimento);
            this.gbox_Receita.Controls.Add(this.btn_Next);
            this.gbox_Receita.Location = new System.Drawing.Point(12, 12);
            this.gbox_Receita.Name = "gbox_Receita";
            this.gbox_Receita.Size = new System.Drawing.Size(231, 132);
            this.gbox_Receita.TabIndex = 999;
            this.gbox_Receita.TabStop = false;
            this.gbox_Receita.Text = "Receita";
            // 
            // cbox_Setor
            // 
            this.cbox_Setor.FormattingEnabled = true;
            this.cbox_Setor.Items.AddRange(new object[] {
            "Refeição",
            "Salgado",
            "Sobremesa"});
            this.cbox_Setor.Location = new System.Drawing.Point(95, 13);
            this.cbox_Setor.Name = "cbox_Setor";
            this.cbox_Setor.Size = new System.Drawing.Size(121, 21);
            this.cbox_Setor.TabIndex = 1;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(95, 40);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(121, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_Rendimento
            // 
            this.txt_Rendimento.Location = new System.Drawing.Point(95, 66);
            this.txt_Rendimento.Name = "txt_Rendimento";
            this.txt_Rendimento.Size = new System.Drawing.Size(121, 20);
            this.txt_Rendimento.TabIndex = 3;
            // 
            // rECEITATableAdapter
            // 
            this.rECEITATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSAVULSOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSRECEITATableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.RECEITATableAdapter = this.rECEITATableAdapter;
            this.tableAdapterManager.UpdateOrder = pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGrid.Location = new System.Drawing.Point(12, 150);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(496, 260);
            this.dataGrid.TabIndex = 999;
            // 
            // pRODUTOSRECEITABindingSource
            // 
            this.pRODUTOSRECEITABindingSource.DataMember = "PRODUTOSRECEITA";
            this.pRODUTOSRECEITABindingSource.DataSource = this._pre_pesagemDataSet;
            // 
            // pRODUTOSRECEITATableAdapter
            // 
            this.pRODUTOSRECEITATableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(433, 416);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Fechar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // CadastrarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 443);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbox_Receita);
            this.Controls.Add(this.gbox_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastrarReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar receita";
            this.Load += new System.EventHandler(this.CadastrarReceita_Load);
            this.gbox_Produtos.ResumeLayout(false);
            this.gbox_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).EndInit();
            this.gbox_Receita.ResumeLayout(false);
            this.gbox_Receita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.GroupBox gbox_Produtos;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gbox_Receita;
        private _pre_pesagemDataSet _pre_pesagemDataSet;
        private _pre_pesagemDataSetTableAdapters.RECEITATableAdapter rECEITATableAdapter;
        private _pre_pesagemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbox_Setor;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Rendimento;
        private System.Windows.Forms.ComboBox cbox_Produto;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource pRODUTOSRECEITABindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter pRODUTOSRECEITATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_Close;
    }
}