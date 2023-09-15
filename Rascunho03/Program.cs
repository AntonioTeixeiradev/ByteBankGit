using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascunho03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RascunhoContacorrente conta = new RascunhoContacorrente();

            conta.nome = "Antonio";
            conta.saldo = 150;

            Console.WriteLine(conta.saldo());





            Console.ReadLine();
        }
    }
}
