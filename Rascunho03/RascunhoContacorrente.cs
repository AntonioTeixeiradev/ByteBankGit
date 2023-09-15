using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascunho03
{
    internal class RascunhoContacorrente
    {
        public string nome;
        private double saldo = 100;
    }

    public double ObterSaldo()
    {
        return saldo;
    }

}
