namespace pre_pesagem
{
    partial class EditarReceita
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label sETORLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label rENDIMENTOLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Receitas = new System.Windows.Forms.ComboBox();
            this.rECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pre_pesagemDataSet = new pre_pesagem._pre_pesagemDataSet();
            this.rECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.RECEITATableAdapter();
            this.tableAdapterManager = new pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cbox_Setor = new System.Windows.Forms.ComboBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Rendimento = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_Receita = new System.Windows.Forms.GroupBox();
            this.gbox_Produtos = new System.Windows.Forms.GroupBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.cbox_Produto = new System.Windows.Forms.ComboBox();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pRODUTOSRECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSRECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter();
            this.pRODUTOSTableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbox_Produtos = new System.Windows.Forms.ListBox();
            iDLabel = new System.Windows.Forms.Label();
            sETORLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            rENDIMENTOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbox_Receita.SuspendLayout();
            this.gbox_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(34, 45);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // sETORLabel
            // 
            sETORLabel.AutoSize = true;
            sETORLabel.Location = new System.Drawing.Point(132, 45);
            sETORLabel.Name = "sETORLabel";
            sETORLabel.Size = new System.Drawing.Size(47, 13);
            sETORLabel.TabIndex = 4;
            sETORLabel.Text = "SETOR:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(270, 16);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 6;
            nOMELabel.Text = "NOME:";
            // 
            // rENDIMENTOLabel
            // 
            rENDIMENTOLabel.AutoSize = true;
            rENDIMENTOLabel.Location = new System.Drawing.Point(332, 45);
            rENDIMENTOLabel.Name = "rENDIMENTOLabel";
            rENDIMENTOLabel.Size = new System.Drawing.Size(83, 13);
            rENDIMENTOLabel.TabIndex = 8;
            rENDIMENTOLabel.Text = "RENDIMENTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEITAS";
            // 
            // cbox_Receitas
            // 
            this.cbox_Receitas.DataSource = this.rECEITABindingSource;
            this.cbox_Receitas.DisplayMember = "NOME";
            this.cbox_Receitas.FormattingEnabled = true;
            this.cbox_Receitas.Location = new System.Drawing.Point(72, 13);
            this.cbox_Receitas.Name = "cbox_Receitas";
            this.cbox_Receitas.Size = new System.Drawing.Size(185, 21);
            this.cbox_Receitas.TabIndex = 1;
            this.cbox_Receitas.ValueMember = "ID";
            this.cbox_Receitas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rECEITABindingSource
            // 
            this.rECEITABindingSource.DataMember = "RECEITA";
            this.rECEITABindingSource.DataSource = this._pre_pesagemDataSet;
            // 
            // _pre_pesagemDataSet
            // 
            this._pre_pesagemDataSet.DataSetName = "_pre_pesagemDataSet";
            this._pre_pesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txt_ID
            // 
            this.txt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEITABindingSource, "ID", true));
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(61, 42);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(47, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // cbox_Setor
            // 
            this.cbox_Setor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEITABindingSource, "SETOR", true));
            this.cbox_Setor.FormattingEnabled = true;
            this.cbox_Setor.Items.AddRange(new object[] {
            "Refeição",
            "Salgado",
            "Sobremesa"});
            this.cbox_Setor.Location = new System.Drawing.Point(185, 42);
            this.cbox_Setor.Name = "cbox_Setor";
            this.cbox_Setor.Size = new System.Drawing.Size(121, 21);
            this.cbox_Setor.TabIndex = 5;
            // 
            // txt_Nome
            // 
            this.txt_Nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEITABindingSource, "NOME", true));
            this.txt_Nome.Location = new System.Drawing.Point(318, 13);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(195, 20);
            this.txt_Nome.TabIndex = 7;
            // 
            // txt_Rendimento
            // 
            this.txt_Rendimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rECEITABindingSource, "RENDIMENTO", true));
            this.txt_Rendimento.Location = new System.Drawing.Point(421, 42);
            this.txt_Rendimento.Name = "txt_Rendimento";
            this.txt_Rendimento.Size = new System.Drawing.Size(92, 20);
            this.txt_Rendimento.TabIndex = 9;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(481, 609);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(380, 609);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Salvar Receita";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(268, 609);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(106, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Apagar Receita";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.dataGrid.Location = new System.Drawing.Point(12, 287);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(548, 316);
            this.dataGrid.TabIndex = 1000;
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
            this.Column2.Width = 253;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gbox_Receita
            // 
            this.gbox_Receita.Controls.Add(this.cbox_Receitas);
            this.gbox_Receita.Controls.Add(this.label1);
            this.gbox_Receita.Controls.Add(this.txt_Rendimento);
            this.gbox_Receita.Controls.Add(rENDIMENTOLabel);
            this.gbox_Receita.Controls.Add(this.txt_Nome);
            this.gbox_Receita.Controls.Add(nOMELabel);
            this.gbox_Receita.Controls.Add(this.cbox_Setor);
            this.gbox_Receita.Controls.Add(sETORLabel);
            this.gbox_Receita.Controls.Add(this.txt_ID);
            this.gbox_Receita.Controls.Add(iDLabel);
            this.gbox_Receita.Location = new System.Drawing.Point(12, 7);
            this.gbox_Receita.Name = "gbox_Receita";
            this.gbox_Receita.Size = new System.Drawing.Size(548, 88);
            this.gbox_Receita.TabIndex = 1009;
            this.gbox_Receita.TabStop = false;
            this.gbox_Receita.Text = "Receita";
            // 
            // gbox_Produtos
            // 
            this.gbox_Produtos.Controls.Add(this.txt_Quantidade);
            this.gbox_Produtos.Controls.Add(this.cbox_Produto);
            this.gbox_Produtos.Controls.Add(this.label3);
            this.gbox_Produtos.Controls.Add(this.label2);
            this.gbox_Produtos.Controls.Add(this.btn_Add);
            this.gbox_Produtos.Location = new System.Drawing.Point(268, 101);
            this.gbox_Produtos.Name = "gbox_Produtos";
            this.gbox_Produtos.Size = new System.Drawing.Size(257, 108);
            this.gbox_Produtos.TabIndex = 1010;
            this.gbox_Produtos.TabStop = false;
            this.gbox_Produtos.Text = "Adicionar produtos";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(86, 43);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(149, 20);
            this.txt_Quantidade.TabIndex = 1013;
            // 
            // cbox_Produto
            // 
            this.cbox_Produto.DataSource = this.pRODUTOSBindingSource;
            this.cbox_Produto.DisplayMember = "NOME";
            this.cbox_Produto.FormattingEnabled = true;
            this.cbox_Produto.Location = new System.Drawing.Point(86, 16);
            this.cbox_Produto.Name = "cbox_Produto";
            this.cbox_Produto.Size = new System.Drawing.Size(149, 21);
            this.cbox_Produto.TabIndex = 1012;
            this.cbox_Produto.ValueMember = "ID";
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this._pre_pesagemDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1011;
            this.label3.Text = "QUANTIDADE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1010;
            this.label2.Text = "PRODUTO:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(160, 69);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1009;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(187, 609);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 1011;
            this.btn_Print.Text = "Imprimir";
            this.btn_Print.UseVisualStyleBackColor = true;
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
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.lbox_Produtos);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 180);
            this.groupBox1.TabIndex = 1012;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remover produtos";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(118, 146);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Remover";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbox_Produtos
            // 
            this.lbox_Produtos.FormattingEnabled = true;
            this.lbox_Produtos.Location = new System.Drawing.Point(23, 19);
            this.lbox_Produtos.Name = "lbox_Produtos";
            this.lbox_Produtos.Size = new System.Drawing.Size(170, 121);
            this.lbox_Produtos.TabIndex = 0;
            // 
            // EditarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.gbox_Produtos);
            this.Controls.Add(this.gbox_Receita);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar receita";
            this.Load += new System.EventHandler(this.EditarReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbox_Receita.ResumeLayout(false);
            this.gbox_Receita.PerformLayout();
            this.gbox_Produtos.ResumeLayout(false);
            this.gbox_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Receitas;
        private _pre_pesagemDataSet _pre_pesagemDataSet;
        private System.Windows.Forms.BindingSource rECEITABindingSource;
        private _pre_pesagemDataSetTableAdapters.RECEITATableAdapter rECEITATableAdapter;
        private _pre_pesagemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cbox_Setor;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Rendimento;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox gbox_Receita;
        private System.Windows.Forms.GroupBox gbox_Produtos;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.BindingSource pRODUTOSRECEITABindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter pRODUTOSRECEITATableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ListBox lbox_Produtos;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.ComboBox cbox_Produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}