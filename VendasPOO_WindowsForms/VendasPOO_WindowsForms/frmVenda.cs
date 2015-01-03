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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
            txtCodigo.Text = RandomCodigos.Codigos();
            foreach (Produto p in Produto.ListarProduto())
            {
                string[] DadosProduto = new string[4];
                DadosProduto[1] = p.Codigo.ToString();
                DadosProduto[2] = p.Nome;
                dgvProdutos.Rows.Add(DadosProduto);
            }
            foreach (Cliente c in Cliente.ListarCliente())
            {
                this.ddlCliente.Items.Add(c.Nome);
            }
        }

        private void lklGerarNovoGuid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCodigo.Text = RandomCodigos.Codigos();
        }

        private void frmVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ddlCliente.SelectedItem != null)
            {
                Venda venda;
                ItensDeVenda(out venda);
                if (Venda.CadastrarVenda(venda) == true)
                {
                    MessageBox.Show("Venda cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK);

                    if (MessageBox.Show("Deseja cadastrar outra venda?", "Confirmação", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                                ((TextBox)item).Clear();
                            else if (item is ComboBox)
                                ((ComboBox)item).SelectedIndex = -1;
                        }
                        txtCodigo.Text = RandomCodigos.Codigos();
                    }
                }
                else
                    MessageBox.Show("Erro inesperado, tente novamente.", "Erro", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Selecione um cliente para fechar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Cliente RetornaCliente()
        {
            foreach (Cliente c in Cliente.ListarCliente())
            {
                if (c.Nome == (string)ddlCliente.SelectedItem)
                {
                    return c;
                }
            }
            return null;
        }

        bool ContinuaVenda;
        private void ItensDeVenda(out Venda venda)
        {
            venda = new Venda();
            venda.Itens = new List<ItemVenda>();
            for (int i = 0; i < dgvProdutos.RowCount - 1; i++)
            {
                foreach (Produto ProdutoSelecionado in Produto.ListarProduto())
                {
                    if (ProdutoSelecionado.Codigo == Convert.ToInt32(dgvProdutos.Rows[i].Cells[1].Value))
                    {
                        ItemVenda ItemComprado = new ItemVenda();
                        ItemComprado.Produto = ProdutoSelecionado;
                        ItemComprado.Quantidade = Convert.ToInt32(dgvProdutos.Rows[i].Cells[3].Value);
                        venda.Codigo = Convert.ToInt32(txtCodigo.Text);
                        venda.Data = DateTime.Now;
                        venda.ICMS = Convert.ToDouble(txtICMS.Text);
                        venda.ValorTotal = ValorTotal();
                        venda.Comprador = RetornaCliente();
                        venda.Comprador.Compras.Add(venda); 
                        ItemComprado.Venda = venda;

                        ContinuaVenda = Estoque(ProdutoSelecionado.Nome.ToString(), 
                            Convert.ToInt32(dgvProdutos.Rows[i].Cells[3].Value));
                        
                        if (ContinuaVenda == true)
                        {
                            int estoque = ItemComprado.Produto.Estoque;
                            ItemComprado.Produto.Estoque = (estoque - ItemComprado.Quantidade);
                            venda.Itens.Add(ItemComprado);
                            ItemComprado.Produto.Itens.Add(ItemComprado);
                        }
                        else
                            MessageBox.Show("Quantidade indisponível em estoque.", "Erro", MessageBoxButtons.OK);
                    }
                }
            }
        }

        bool Retorno;
        private bool Estoque(string NomeProduto, int Quantidade)
        {
            string Nome = NomeProduto;
            int Estoque = Quantidade;
            foreach (Produto p in Produto.ListarProduto())
            {
                if (p.Nome == Nome)
                {
                    int QtdeAtual = p.Estoque;
                    if (QtdeAtual > Estoque)
                        Retorno = true;
                    else
                        Retorno = false;
                }
            }
            return Retorno;
        }

        double ValorCompra;
        public double ValorTotal()
        {
            for (int i = 0; i < dgvProdutos.RowCount - 1; i++)
            {
                foreach (Produto ProdutoEscolhido in Produto.ListarProduto())
                {
                    if (ProdutoEscolhido.Codigo == Convert.ToInt32(dgvProdutos.Rows[i].Cells[1].Value))
                    {
                        ValorCompra = ValorCompra + ProdutoEscolhido.PrecoVenda;
                    }
                }
            }
            return ValorCompra;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
