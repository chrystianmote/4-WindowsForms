using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class Produto
    {
        public int Codigo;
        public string Nome;
        public double PrecoCusto;
        public double PrecoVenda;
        public int Estoque;
        public string Descricao;
        public DateTime DataCadastro;
        public List<ItemVenda> Itens;

        public static List<Produto> Produtos = new List<Produto>();
        
        public static bool CadastrarProduto(Produto produto)
        {           
            Produtos.Add(produto);
            if (Produtos.Count > 0)
                return true;
            else
                return false;
        }

        public static List<Produto> ListarProduto()
        {
            if (Produtos.Count > 0)
                return Produtos;
            else
                return null;
        }
    }
}
