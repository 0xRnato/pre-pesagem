namespace pre_pesagem
{
    partial class ListarProdutos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pre_pesagemDataSet = new pre_pesagem._pre_pesagemDataSet();
            this.pRODUTOSTableAdapter = new pre_pesagem._pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.uNIDADEDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUTOSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNIDADEDataGridViewTextBoxColumn
            // 
            this.uNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE";
            this.uNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE";
            this.uNIDADEDataGridViewTextBoxColumn.Name = "uNIDADEDataGridViewTextBoxColumn";
            this.uNIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(356, 332);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "Imprimir";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 363);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista dos produtos";
            this.Load += new System.EventHandler(this.ListarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pre_pesagemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _pre_pesagemDataSet _pre_pesagemDataSet;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private _pre_pesagemDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Print;
    }
}