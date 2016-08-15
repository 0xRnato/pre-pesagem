namespace pre_pesagem
{
    partial class EditarProduto
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
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label uNIDADELabel;
            System.Windows.Forms.Label vALORLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.box_Produtos = new System.Windows.Forms.ComboBox();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pre_pesagemDataSet = new pre_pesagem._pre_pesagemDataSet();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pRODUTOSTableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_NOME = new System.Windows.Forms.TextBox();
            this.txt_UNIDADE = new System.Windows.Forms.TextBox();
            this.txt_VALOR = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            uNIDADELabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(148, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            iDLabel.Visible = false;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(148, 57);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 7;
            nOMELabel.Text = "NOME:";
            // 
            // uNIDADELabel
            // 
            uNIDADELabel.AutoSize = true;
            uNIDADELabel.Location = new System.Drawing.Point(148, 83);
            uNIDADELabel.Name = "uNIDADELabel";
            uNIDADELabel.Size = new System.Drawing.Size(59, 13);
            uNIDADELabel.TabIndex = 9;
            uNIDADELabel.Text = "UNIDADE:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(148, 109);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(46, 13);
            vALORLabel.TabIndex = 11;
            vALORLabel.Text = "VALOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTOS";
            // 
            // box_Produtos
            // 
            this.box_Produtos.DataSource = this.pRODUTOSBindingSource;
            this.box_Produtos.DisplayMember = "NOME";
            this.box_Produtos.FormattingEnabled = true;
            this.box_Produtos.Location = new System.Drawing.Point(157, 6);
            this.box_Produtos.Name = "box_Produtos";
            this.box_Produtos.Size = new System.Drawing.Size(207, 21);
            this.box_Produtos.TabIndex = 1;
            this.box_Produtos.ValueMember = "ID";
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
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(127, 157);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Deletar";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(208, 157);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(289, 157);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSAVULSOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSRECEITATableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = this.pRODUTOSTableAdapter;
            this.tableAdapterManager.RECEITATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_ID
            // 
            this.txt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "ID", true));
            this.txt_ID.Location = new System.Drawing.Point(213, 28);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 99;
            this.txt_ID.Visible = false;
            // 
            // txt_NOME
            // 
            this.txt_NOME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "NOME", true));
            this.txt_NOME.Location = new System.Drawing.Point(213, 54);
            this.txt_NOME.Name = "txt_NOME";
            this.txt_NOME.Size = new System.Drawing.Size(100, 20);
            this.txt_NOME.TabIndex = 2;
            // 
            // txt_UNIDADE
            // 
            this.txt_UNIDADE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "UNIDADE", true));
            this.txt_UNIDADE.Location = new System.Drawing.Point(213, 80);
            this.txt_UNIDADE.Name = "txt_UNIDADE";
            this.txt_UNIDADE.Size = new System.Drawing.Size(100, 20);
            this.txt_UNIDADE.TabIndex = 3;
            // 
            // txt_VALOR
            // 
            this.txt_VALOR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "VALOR", true));
            this.txt_VALOR.Location = new System.Drawing.Point(213, 106);
            this.txt_VALOR.Name = "txt_VALOR";
            this.txt_VALOR.Size = new System.Drawing.Size(100, 20);
            this.txt_VALOR.TabIndex = 4;
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 192);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txt_NOME);
            this.Controls.Add(uNIDADELabel);
            this.Controls.Add(this.txt_UNIDADE);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.txt_VALOR);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.box_Produtos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar produto";
            this.Load += new System.EventHandler(this.EditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_Produtos;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private _pre_pesagemDataSet _pre_pesagemDataSet;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private _pre_pesagemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_NOME;
        private System.Windows.Forms.TextBox txt_UNIDADE;
        private System.Windows.Forms.TextBox txt_VALOR;
    }
}