namespace VendasPOO_WindowsForms
{
    partial class frmVenda
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
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lklGerarNovoGuid = new System.Windows.Forms.LinkLabel();
            this.lblICMS = new System.Windows.Forms.Label();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.lblProdutosDisponiveis = new System.Windows.Forms.Label();
            this.ddlCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(12, 9);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(134, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lklGerarNovoGuid
            // 
            this.lklGerarNovoGuid.AutoSize = true;
            this.lklGerarNovoGuid.Location = new System.Drawing.Point(61, 9);
            this.lklGerarNovoGuid.Name = "lklGerarNovoGuid";
            this.lklGerarNovoGuid.Size = new System.Drawing.Size(39, 13);
            this.lklGerarNovoGuid.TabIndex = 2;
            this.lklGerarNovoGuid.TabStop = true;
            this.lklGerarNovoGuid.Text = "[Novo]";
            this.lklGerarNovoGuid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGerarNovoGuid_LinkClicked);
            // 
            // lblICMS
            // 
            this.lblICMS.AutoSize = true;
            this.lblICMS.Location = new System.Drawing.Point(163, 9);
            this.lblICMS.Name = "lblICMS";
            this.lblICMS.Size = new System.Drawing.Size(36, 13);
            this.lblICMS.TabIndex = 3;
            this.lblICMS.Text = "ICMS:";
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(166, 25);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(134, 20);
            this.txtICMS.TabIndex = 4;
            this.txtICMS.Text = " ";
            // 
            // lblProdutosDisponiveis
            // 
            this.lblProdutosDisponiveis.AutoSize = true;
            this.lblProdutosDisponiveis.Location = new System.Drawing.Point(12, 62);
            this.lblProdutosDisponiveis.Name = "lblProdutosDisponiveis";
            this.lblProdutosDisponiveis.Size = new System.Drawing.Size(109, 13);
            this.lblProdutosDisponiveis.TabIndex = 6;
            this.lblProdutosDisponiveis.Text = "Produtos disponíveis:";
            // 
            // ddlCliente
            // 
            this.ddlCliente.FormattingEnabled = true;
            this.ddlCliente.Location = new System.Drawing.Point(321, 24);
            this.ddlCliente.Name = "ddlCliente";
            this.ddlCliente.Size = new System.Drawing.Size(277, 21);
            this.ddlCliente.TabIndex = 9;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(318, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(523, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Codigo,
            this.Nom,
            this.Quantidade});
            this.dgvProdutos.Location = new System.Drawing.Point(15, 78);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(583, 150);
            this.dgvProdutos.TabIndex = 29;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 20;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 120;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nome";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 300;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 288);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.ddlCliente);
            this.Controls.Add(this.lblProdutosDisponiveis);
            this.Controls.Add(this.txtICMS);
            this.Controls.Add(this.lblICMS);
            this.Controls.Add(this.lklGerarNovoGuid);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoVenda);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV - Nova Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenda_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.LinkLabel lklGerarNovoGuid;
        private System.Windows.Forms.Label lblICMS;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.Label lblProdutosDisponiveis;
        private System.Windows.Forms.ComboBox ddlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}