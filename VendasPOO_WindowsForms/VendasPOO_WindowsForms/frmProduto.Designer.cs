namespace VendasPOO_WindowsForms
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
            this.lklGerarNovoGuid = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lklGerarNovoGuid
            // 
            this.lklGerarNovoGuid.AutoSize = true;
            this.lklGerarNovoGuid.Location = new System.Drawing.Point(58, 15);
            this.lklGerarNovoGuid.Name = "lklGerarNovoGuid";
            this.lklGerarNovoGuid.Size = new System.Drawing.Size(39, 13);
            this.lklGerarNovoGuid.TabIndex = 1;
            this.lklGerarNovoGuid.TabStop = true;
            this.lklGerarNovoGuid.Text = "[Novo]";
            this.lklGerarNovoGuid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGerarNovoGuid_LinkClicked);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(170, 15);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(93, 13);
            this.lblNomeProduto.TabIndex = 5;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(173, 31);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(283, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(9, 68);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoCusto.TabIndex = 7;
            this.lblPrecoCusto.Text = "Preço de Custo:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(12, 84);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(140, 20);
            this.txtPrecoCusto.TabIndex = 3;
            this.txtPrecoCusto.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoCusto_Validating);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(170, 68);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 9;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(173, 84);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(140, 20);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoVenda_Validating);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(331, 68);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 11;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(334, 84);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(122, 20);
            this.txtEstoque.TabIndex = 5;
            this.txtEstoque.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstoque_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(494, 290);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 143);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(444, 105);
            this.txtObs.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(9, 127);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 13);
            this.lblDesc.TabIndex = 23;
            this.lblDesc.Text = "Descrição do Produto:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(381, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 303);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lklGerarNovoGuid);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV - Novo Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduto_FormClosing);
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklGerarNovoGuid;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnSalvar;
    }
}