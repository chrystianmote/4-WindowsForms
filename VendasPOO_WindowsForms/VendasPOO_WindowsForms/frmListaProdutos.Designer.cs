namespace VendasPOO_WindowsForms
{
    partial class frmListaProdutos
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
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.PrecoCusto,
            this.PrecoVenda,
            this.Estoque});
            this.dgvListaProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.Size = new System.Drawing.Size(663, 330);
            this.dgvListaProdutos.TabIndex = 1;
            this.dgvListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProdutos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 130;
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // PrecoCusto
            // 
            this.PrecoCusto.Frozen = true;
            this.PrecoCusto.HeaderText = "Preço de Custo";
            this.PrecoCusto.Name = "PrecoCusto";
            this.PrecoCusto.ReadOnly = true;
            this.PrecoCusto.Width = 130;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.Frozen = true;
            this.PrecoVenda.HeaderText = "Preço de Venda";
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.ReadOnly = true;
            this.PrecoVenda.Width = 130;
            // 
            // Estoque
            // 
            this.Estoque.Frozen = true;
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 80;
            // 
            // frmListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(664, 330);
            this.Controls.Add(this.dgvListaProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV - Lista de Produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListaProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
    }
}