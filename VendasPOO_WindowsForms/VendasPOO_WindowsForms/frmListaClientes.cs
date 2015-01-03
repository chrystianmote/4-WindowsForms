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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
            foreach (Cliente c in Cliente.ListarCliente())
            {
                string[] dados = new string[6];
                dados[0] = c.Codigo.ToString();
                dados[1] = c.Nome;
                dados[2] = c.DataNascimento.ToString("dd/MM/yyyy");
                dados[3] = c.Rua + ", " + c.Numero.ToString() + " - " + c.Cidade + " - " + c.UF;
                dados[4] = c.Telefone.ToString();
                dados[5] = c.Email.ToString();
                dgvListaClientes.Rows.Add(dados);
            }
        }

        private void frmListaClientes_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
