using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class Cliente
    {
        public int Codigo;
        public string Nome;
        public DateTime DataNascimento;
        public string Telefone;
        public string Email;
        public string Rua;
        public int Numero;
        public string Cidade;
        public string UF;
        public string Observacoes;
        public DateTime DataCadastro;
        public List<Venda> Compras;

        public static List<Cliente> Clientes = new List<Cliente>();

        public static bool Cadastrar(Cliente cliente)
        {
            Clientes.Add(cliente);
            if (Clientes.Count > 0)
                return true;
            else
                return false;
        }

        public static List<Cliente> ListarCliente()
        {
            if (Clientes.Count > 0)
                return Clientes;
            else
                return null;
        }
    }
    
}
