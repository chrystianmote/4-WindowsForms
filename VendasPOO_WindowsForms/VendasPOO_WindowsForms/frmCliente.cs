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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            txtCodigo.Text = RandomCodigos.Codigos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklGerarNovoGuid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCodigo.Text = RandomCodigos.Codigos();
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void RemoverFormatacao()
        {
            lblNumero.ForeColor = System.Drawing.Color.Black;
            lblDataNasc.ForeColor = System.Drawing.Color.Black;
            lblNumero.Font = new Font(lblNumero.Font, FontStyle.Regular);
            lblDataNasc.Font = new Font(lblDataNasc.Font, FontStyle.Regular);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.DataNascimento = Convert.ToDateTime(txtDataNasc.Text);
            cliente.Rua = txtRua.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Cidade = txtCidade.Text;
            cliente.UF = ddlUF.SelectedItem.ToString();
            cliente.Observacoes = txtObs.Text;
            cliente.DataCadastro = DateTime.Now;
            cliente.Compras = new List<Venda>();
            if (Cliente.Cadastrar(cliente) == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);

                if (MessageBox.Show("Deseja cadastrar outro cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                MessageBox.Show("Erro ao cadastrar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDataNasc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime DataNasc = Convert.ToDateTime(txtDataNasc.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Data inválida. Digite no formato dd/mm/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Text = "";
                lblDataNasc.ForeColor = System.Drawing.Color.Red;
                lblDataNasc.Font = new Font(lblDataNasc.Font, FontStyle.Bold);
                e.Cancel = true;
            }
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int Numero = Convert.ToInt32(txtNumero.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira apenas números neste campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Text = "";
                lblNumero.ForeColor = System.Drawing.Color.Red;
                lblNumero.Font = new Font(lblNumero.Font, FontStyle.Bold);
                e.Cancel = true;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
