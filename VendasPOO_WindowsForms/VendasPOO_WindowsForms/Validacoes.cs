using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class Validacoes
    {
        public static bool ValidarInicioVenda()
        {
            if (Cliente.ListarCliente() != null && Produto.ListarProduto() != null)
                return true;
            else
                return false;
        }

        public static bool ValidarListaCliente()
        {
            if (Cliente.ListarCliente() != null)
                return true;
            else
                return false;
        }

        public static bool ValidarListaProduto()
        {
            if (Produto.ListarProduto() != null)
                return true;
            else
                return false;
        }

        public static bool ValidarListaVenda()
        {
            if (Venda.ListarVenda() != null)
                return true;
            else
                return false;
        }
    }
}
