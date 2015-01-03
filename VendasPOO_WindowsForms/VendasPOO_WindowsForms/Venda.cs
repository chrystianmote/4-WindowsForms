using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class Venda
    {
        public int Codigo;
        public DateTime Data;
        public double ICMS;
        public double ValorTotal;
        public Cliente Comprador;
        public List<ItemVenda> Itens;
        
        public static List<Venda> Vendas = new List<Venda>();

        public static bool CadastrarVenda(Venda Venda)
        {
            Vendas.Add(Venda);
            if (Vendas.Count > 0)
                return true;
            else
                return false;
        }

        public static List<Venda> ListarVenda()
        {
            if (Vendas.Count > 0)
                return Vendas;
            else
                return null;
        }
    }
}
