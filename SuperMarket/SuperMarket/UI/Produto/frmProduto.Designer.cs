namespace SuperMarket.UI.Produto
{
    partial class frmProduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFabricação = new System.Windows.Forms.DateTimePicker();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrigem = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(257, 73);
            this.txtProduto.Multiline = true;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(126, 24);
            this.txtProduto.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(190, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 21);
            this.label.TabIndex = 2;
            this.label.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Validade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fabricação:";
            // 
            // dtpFabricação
            // 
            this.dtpFabricação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFabricação.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFabricação.Location = new System.Drawing.Point(257, 157);
            this.dtpFabricação.Name = "dtpFabricação";
            this.dtpFabricação.Size = new System.Drawing.Size(126, 24);
            this.dtpFabricação.TabIndex = 7;
            // 
            // dtpValidade
            // 
            this.dtpValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(257, 116);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(126, 24);
            this.dtpValidade.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Origem:";
            // 
            // cboOrigem
            // 
            this.cboOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigem.FormattingEnabled = true;
            this.cboOrigem.Location = new System.Drawing.Point(257, 199);
            this.cboOrigem.Name = "cboOrigem";
            this.cboOrigem.Size = new System.Drawing.Size(126, 24);
            this.cboOrigem.TabIndex = 29;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(257, 242);
            this.txtValorVenda.Multiline = true;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(126, 24);
            this.txtValorVenda.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Valor de venda:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(257, 317);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 34);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.dtpFabricação);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFabricação;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrigem;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
    }
}