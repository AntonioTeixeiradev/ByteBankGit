using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "Antonio";
            cliente.CPF = "123.123.123-12";
            cliente.Profissao = "Desenvolvedor";



            conta.Saldo = -10;
            conta.Titular = cliente;


            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);






            Console.ReadLine();
        }
    }
}
