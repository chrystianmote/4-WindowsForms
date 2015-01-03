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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
            txtCodigo.Text = RandomCodigos.Codigos();
        }

        private void lklGerarNovoGuid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCodigo.Text = RandomCodigos.Codigos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Codigo = Convert.ToInt32(txtCodigo.Text);
            produto.Nome = txtNomeProduto.Text;
            produto.PrecoCusto = Convert.ToDouble(txtPrecoCusto.Text);
            produto.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            produto.Estoque = Convert.ToInt32(txtEstoque.Text);
            produto.Descricao = txtObs.Text;
            produto.DataCadastro = DateTime.Now;
            produto.Itens = new List<ItemVenda>();
            if (Produto.CadastrarProduto(produto) == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);

                if (MessageBox.Show("Deseja cadastrar outro produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                    RemoverFormatacao();
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoverFormatacao()
        {
            lblEstoque.ForeColor = System.Drawing.Color.Black;
            lblPrecoCusto.ForeColor = System.Drawing.Color.Black;
            lblPrecoVenda.ForeColor = System.Drawing.Color.Black;
            lblEstoque.Font = new Font(lblEstoque.Font, FontStyle.Regular);
            lblPrecoCusto.Font = new Font(lblPrecoCusto.Font, FontStyle.Regular);
            lblPrecoVenda.Font = new Font(lblPrecoVenda.Font, FontStyle.Regular);
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPrecoCusto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double PrecoCusto = Convert.ToDouble(txtPrecoCusto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor em formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoCusto.Text = "";
                lblPrecoCusto.ForeColor = System.Drawing.Color.Red;
                lblPrecoCusto.Font = new Font(lblPrecoCusto.Font, FontStyle.Bold);
                e.Cancel = true;
            }
        }

        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor em formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Text = "";
                lblPrecoVenda.ForeColor = System.Drawing.Color.Red;
                lblPrecoVenda.Font = new Font(lblPrecoVenda.Font, FontStyle.Bold);
                e.Cancel = true;
            }
        }

        private void txtEstoque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int Estoque = Convert.ToInt32(txtEstoque.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor em formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstoque.Text = "";
                lblEstoque.ForeColor = System.Drawing.Color.Red;
                lblEstoque.Font = new Font(lblEstoque.Font, FontStyle.Bold);
                e.Cancel = true;
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
