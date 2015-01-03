using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendasPOO_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
            lblCarregamentos.BackColor = System.Drawing.Color.Transparent;
            timerLoading.Enabled = true;
            timerLoading.Start();
            timerLoading.Interval = 1000;
            pbLoading.Maximum = 10;
            timerLoading.Tick += new EventHandler(timerLoading_Tick);
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value != 10)
            {
                pbLoading.Value++;
            }
            else
            {
                timerLoading.Stop();
                pbLoading.Visible = false;
                lblCarregamentos.Visible = false;
                menuStrip1.Visible = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto Produto = new frmProduto();
            Produto.ShowDialog();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ValidarInicioVenda = Validacoes.ValidarInicioVenda();
            if (ValidarInicioVenda == true)
            {
                frmVenda Venda = new frmVenda();
                Venda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Antes de gerar uma venda, cadastre usuários e produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sobreOSCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool Validacao;
            switch (e.KeyCode)
            {
                case Keys.F2:
                    frmCliente Cliente = new frmCliente();
                    Cliente.ShowDialog();
                    break;
                case Keys.F3:
                    frmProduto Produto = new frmProduto();
                    Produto.ShowDialog();
                    break;
                case Keys.F5:
                    bool ValidarInicioVenda = Validacoes.ValidarInicioVenda();
                    if (ValidarInicioVenda == true)
                    {
                        frmVenda Venda = new frmVenda();
                        Venda.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Antes de gerar uma venda, cadastre usuários e produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case Keys.F8:
                    Validacao = Validacoes.ValidarListaCliente();
                    if (Validacao == true)
                    {
                        frmListaClientes Clientes = new frmListaClientes();
                        Clientes.ShowDialog();
                    }
                    else
                        MessageBox.Show("Não há nenhum cliente para ser exibido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.F9:
                    Validacao = Validacoes.ValidarListaProduto();
                    if (Validacao == true)
                    {
                        frmListaProdutos Produtos = new frmListaProdutos();
                        Produtos.ShowDialog();
                    }
                    else
                        MessageBox.Show("Não há nenhum produto para ser exibido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.F10:
                    Validacao = Validacoes.ValidarListaVenda();
                    if (Validacao == true)
                    {
                        frmListaVendas Vendas = new frmListaVendas();
                        Vendas.ShowDialog();
                    }
                    else
                        MessageBox.Show("Não há nenhuma venda para ser exibida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.F12:
                    frmSobre Sobre = new frmSobre();
                    Sobre.ShowDialog();
                    break;
                default:
                    //MessageBox.Show("Erro. Atalho não encontrado!", "Erro");
                    break;

            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Log = Logs.LogClientes();
            if (Log == true)
                MessageBox.Show("Relatório gerado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Não há dados para serem exportados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Log = Logs.LogProdutos();
            if (Log == true)
                MessageBox.Show("Relatório gerado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Não há dados para serem exportados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Log = Logs.LogVendas();
            if (Log == true)
                MessageBox.Show("Relatório gerado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Não há dados para serem exportados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Validacao = Validacoes.ValidarListaCliente();
            if (Validacao == true)
            {
                frmListaClientes Clientes = new frmListaClientes();
                Clientes.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhum cliente para ser exibido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Validacao = Validacoes.ValidarListaProduto();
            if (Validacao == true)
            {
                frmListaProdutos Produtos = new frmListaProdutos();
                Produtos.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhum produto para ser exibido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listaDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Validacao = Validacoes.ValidarListaVenda();
            if (Validacao == true)
            {
                frmListaVendas Vendas = new frmListaVendas();
                Vendas.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhuma venda para ser exibida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
