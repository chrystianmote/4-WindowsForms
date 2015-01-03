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
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
            foreach (Produto p in Produto.ListarProduto())
            {
                string[] Dados = new string[5];
                Dados[0] = p.Codigo.ToString();
                Dados[1] = p.Nome;
                Dados[2] = "R$ " + p.PrecoCusto.ToString();
                Dados[3] = "R$ " + p.PrecoVenda.ToString();
                Dados[4] = p.Estoque.ToString();
                dgvListaProdutos.Rows.Add(Dados);
            }
        }

        private void frmListaProdutos_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
