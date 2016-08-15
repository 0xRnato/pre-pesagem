namespace pre_pesagem
{
    partial class CadastrarProduto
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
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label uNIDADELabel;
            System.Windows.Forms.Label vALORLabel;
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Unidade = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            nOMELabel = new System.Windows.Forms.Label();
            uNIDADELabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(96, 43);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            // 
            // uNIDADELabel
            // 
            uNIDADELabel.AutoSize = true;
            uNIDADELabel.Location = new System.Drawing.Point(96, 69);
            uNIDADELabel.Name = "uNIDADELabel";
            uNIDADELabel.Size = new System.Drawing.Size(59, 13);
            uNIDADELabel.TabIndex = 5;
            uNIDADELabel.Text = "UNIDADE:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(96, 95);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(46, 13);
            vALORLabel.TabIndex = 7;
            vALORLabel.Text = "VALOR:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(161, 40);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(175, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Unidade
            // 
            this.txt_Unidade.Location = new System.Drawing.Point(161, 66);
            this.txt_Unidade.Name = "txt_Unidade";
            this.txt_Unidade.Size = new System.Drawing.Size(175, 20);
            this.txt_Unidade.TabIndex = 2;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(161, 92);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(175, 20);
            this.txt_Valor.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(180, 130);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(261, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 175);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(uNIDADELabel);
            this.Controls.Add(this.txt_Unidade);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.txt_Valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Unidade;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}