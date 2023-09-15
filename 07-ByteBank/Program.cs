using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente juliane = new ContaCorrente(7480, 875421);


            juliane.Saldo = 200;
            Console.WriteLine(juliane.Saldo);
            


            Console.ReadLine();


            

        }
    }
}
