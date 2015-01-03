using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendasPOO_WindowsForms
{
    class RandomCodigos
    {
        public static string Codigos()
        {
            string Codigo = "";
            Random rdn = new Random();
            Codigo = "00000" + rdn.Next(100, 10000000).ToString();
            return Codigo;
        }
    }
}
