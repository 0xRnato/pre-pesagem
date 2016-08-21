namespace pre_pesagem
{
    partial class ListarReceitas
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
            this._pre_pesagemDataSet = new pre_pesagem._pre_pesagemDataSet();
            this.rECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.RECEITATableAdapter();
            this.tableAdapterManager = new pre_pesagem._pre_pesagemDataSetTableAdapters.TableAdapterManager();
            this.rECEITADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSRECEITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSRECEITATableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter();
            this.pRODUTOSRECEITADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _pre_pesagemDataSet
            // 
            this._pre_pesagemDataSet.DataSetName = "_pre_pesagemDataSet";
            this._pre_pesagemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECEITABindingSource
            // 
            this.rECEITABindingSource.DataMember = "RECEITA";
            this.rECEITABindingSource.DataSource = this._pre_pesagemDataSet;
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
            // rECEITADataGridView
            // 
            this.rECEITADataGridView.AllowUserToAddRows = false;
            this.rECEITADataGridView.AllowUserToDeleteRows = false;
            this.rECEITADataGridView.AllowUserToOrderColumns = true;
            this.rECEITADataGridView.AutoGenerateColumns = false;
            this.rECEITADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rECEITADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.rECEITADataGridView.DataSource = this.rECEITABindingSource;
            this.rECEITADataGridView.Location = new System.Drawing.Point(0, 0);
            this.rECEITADataGridView.Name = "rECEITADataGridView";
            this.rECEITADataGridView.ReadOnly = true;
            this.rECEITADataGridView.Size = new System.Drawing.Size(443, 390);
            this.rECEITADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SETOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "SETOR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RENDIMENTO";
            this.dataGridViewTextBoxColumn4.HeaderText = "RENDIMENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // pRODUTOSRECEITADataGridView
            // 
            this.pRODUTOSRECEITADataGridView.AllowUserToAddRows = false;
            this.pRODUTOSRECEITADataGridView.AllowUserToDeleteRows = false;
            this.pRODUTOSRECEITADataGridView.AllowUserToOrderColumns = true;
            this.pRODUTOSRECEITADataGridView.AutoGenerateColumns = false;
            this.pRODUTOSRECEITADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUTOSRECEITADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pRODUTOSRECEITADataGridView.DataSource = this.pRODUTOSRECEITABindingSource;
            this.pRODUTOSRECEITADataGridView.Location = new System.Drawing.Point(449, 0);
            this.pRODUTOSRECEITADataGridView.Name = "pRODUTOSRECEITADataGridView";
            this.pRODUTOSRECEITADataGridView.ReadOnly = true;
            this.pRODUTOSRECEITADataGridView.Size = new System.Drawing.Size(446, 390);
            this.pRODUTOSRECEITADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn7.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_RECEITA";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_RECEITA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ListarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 398);
            this.Controls.Add(this.pRODUTOSRECEITADataGridView);
            this.Controls.Add(this.rECEITADataGridView);
            this.Name = "ListarReceitas";
            this.Text = "ListarReceitas";
            this.Load += new System.EventHandler(this.ListarReceitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECEITADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSRECEITADataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _pre_pesagemDataSet _pre_pesagemDataSet;
        private System.Windows.Forms.BindingSource rECEITABindingSource;
        private _pre_pesagemDataSetTableAdapters.RECEITATableAdapter rECEITATableAdapter;
        private _pre_pesagemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rECEITADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource pRODUTOSRECEITABindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSRECEITATableAdapter pRODUTOSRECEITATableAdapter;
        private System.Windows.Forms.DataGridView pRODUTOSRECEITADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}