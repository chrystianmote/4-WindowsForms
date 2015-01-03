using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class Logs
    {
        public static bool LogClientes()
        {
            string Caminho = "C:\\Log_Clientes.txt";
            if (System.IO.File.Exists(Caminho))
            {
                System.IO.File.Create(Caminho).Close();
            }
            System.IO.TextWriter Log = System.IO.File.AppendText(Caminho);
            if (Cliente.ListarCliente() != null)
            {
                Log.Write("----- CLIENTES CADASTRADOS -----");
                foreach (Cliente c in Cliente.ListarCliente())
                {
                    Log.WriteLine("");
                    Log.WriteLine("Código: " + c.Codigo + " - " + c.Nome);
                }
                Log.Write("--------------------------------");
                Log.Close();
                return true;
            }
            else
                return false;
        }

        public static bool LogProdutos()
        {
            string Caminho = "C:\\Log_Produtos.txt";
            if (System.IO.File.Exists(Caminho))
            {
                System.IO.File.Create(Caminho).Close();
            }
            System.IO.TextWriter Log = System.IO.File.AppendText(Caminho);
            if (Produto.ListarProduto() != null)
            {
                Log.Write("----- PRODUTOS CADASTRADOS -----\n");
                Log.WriteLine("");
                foreach (Produto p in Produto.ListarProduto())
                {
                    Log.WriteLine("Código: " + p.Codigo + " - " + p.Nome);
                }
                Log.Write("-------------------------------");
                Log.Close();
                return true;
            }
            else
                return false;
        }

        public static bool LogVendas()
        {
            string Caminho = "C:\\Log_Vendas.txt";
            if (System.IO.File.Exists(Caminho))
            {
                System.IO.File.Create(Caminho).Close();
            }
            System.IO.TextWriter Log = System.IO.File.AppendText(Caminho);
            if (Venda.ListarVenda() != null)
            {
                Log.Write("----- VENDAS CADASTRADOS -----\n");
                Log.WriteLine("");
                foreach (Venda v in Venda.ListarVenda())
                {
                    Log.WriteLine("Código: " + v.Codigo + " - " + v.Comprador + " - " + v.Itens);
                }
                Log.Write("-------------------------------");
                Log.Close();
                return true;
            }
            else
                return false;
        }

    }
}
