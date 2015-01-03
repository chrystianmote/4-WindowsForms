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
    public partial class frmListaVendas : Form
    {
        public frmListaVendas()
        {
            InitializeComponent();
            foreach (Venda venda in Venda.ListarVenda())
            {
                string[] Dados = new string[5];
                Dados[0] = venda.Codigo.ToString();
                Dados[1] = venda.Comprador.Nome;
                Dados[2] = venda.ValorTotal.ToString();
                Dados[3] = venda.Data.ToString("dd/MM/yyyy");
                Dados[4] = venda.Itens.Count.ToString();
                dgvListaVendas.Rows.Add(Dados);

            }
        }

        private void frmListaVendas_KeyDown(object sender, KeyEventArgs e)
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
