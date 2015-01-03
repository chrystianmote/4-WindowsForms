namespace VendasPOO_WindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaDoSCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosDeUtilizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMinhaOpiniãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOSCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.lblCarregamentos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.novoProdutoToolStripMenuItem,
            this.novaVendaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo cliente        F2";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo produto     F3";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova venda         F5";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesToolStripMenuItem,
            this.listaDeToolStripMenuItem,
            this.listaDeVendasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.pesquisarToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de clientes        F8";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // listaDeToolStripMenuItem
            // 
            this.listaDeToolStripMenuItem.Name = "listaDeToolStripMenuItem";
            this.listaDeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaDeToolStripMenuItem.Text = "Lista de produtos     F9";
            this.listaDeToolStripMenuItem.Click += new System.EventHandler(this.listaDeToolStripMenuItem_Click);
            // 
            // listaDeVendasToolStripMenuItem
            // 
            this.listaDeVendasToolStripMenuItem.Name = "listaDeVendasToolStripMenuItem";
            this.listaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.listaDeVendasToolStripMenuItem.Text = "Lista de vendas        F10";
            this.listaDeVendasToolStripMenuItem.Click += new System.EventHandler(this.listaDeVendasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.vendasToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar...";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDadosToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // exportarDadosToolStripMenuItem
            // 
            this.exportarDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.exportarDadosToolStripMenuItem.Name = "exportarDadosToolStripMenuItem";
            this.exportarDadosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportarDadosToolStripMenuItem.Text = "Exportar dados...";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.vendaToolStripMenuItem.Text = "Vendas";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaDoSCVToolStripMenuItem,
            this.dadosDeUtilizaçãoToolStripMenuItem,
            this.enviarMinhaOpiniãoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sobreOSCVToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaDoSCVToolStripMenuItem
            // 
            this.ajudaDoSCVToolStripMenuItem.Name = "ajudaDoSCVToolStripMenuItem";
            this.ajudaDoSCVToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajudaDoSCVToolStripMenuItem.Text = "Ajuda do SCV";
            // 
            // dadosDeUtilizaçãoToolStripMenuItem
            // 
            this.dadosDeUtilizaçãoToolStripMenuItem.Name = "dadosDeUtilizaçãoToolStripMenuItem";
            this.dadosDeUtilizaçãoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dadosDeUtilizaçãoToolStripMenuItem.Text = "Dados para suporte";
            // 
            // enviarMinhaOpiniãoToolStripMenuItem
            // 
            this.enviarMinhaOpiniãoToolStripMenuItem.Name = "enviarMinhaOpiniãoToolStripMenuItem";
            this.enviarMinhaOpiniãoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.enviarMinhaOpiniãoToolStripMenuItem.Text = "Enviar minha opinião...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // sobreOSCVToolStripMenuItem
            // 
            this.sobreOSCVToolStripMenuItem.Name = "sobreOSCVToolStripMenuItem";
            this.sobreOSCVToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sobreOSCVToolStripMenuItem.Text = "Sobre o SCV     F12";
            this.sobreOSCVToolStripMenuItem.Click += new System.EventHandler(this.sobreOSCVToolStripMenuItem_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(12, 514);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(377, 23);
            this.pbLoading.TabIndex = 2;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // lblCarregamentos
            // 
            this.lblCarregamentos.AutoSize = true;
            this.lblCarregamentos.BackColor = System.Drawing.SystemColors.Window;
            this.lblCarregamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregamentos.ForeColor = System.Drawing.Color.White;
            this.lblCarregamentos.Location = new System.Drawing.Point(9, 498);
            this.lblCarregamentos.Name = "lblCarregamentos";
            this.lblCarregamentos.Size = new System.Drawing.Size(281, 13);
            this.lblCarregamentos.TabIndex = 3;
            this.lblCarregamentos.Text = "Aguarde, carregando componentes do sistema...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 549);
            this.Controls.Add(this.lblCarregamentos);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCV - Sistema de Cadastro e Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaDoSCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosDeUtilizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMinhaOpiniãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreOSCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label lblCarregamentos;

    }
}

