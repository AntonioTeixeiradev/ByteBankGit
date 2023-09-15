using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);

            bool resultadoSaque = contaBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaBruno.saldo);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";


            Console.WriteLine("Saldo do bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaGabriela.saldo);


            bool resultadoTransferencia = contaBruno.Transferir(200, contaGabriela);

            Console.WriteLine("Saldo do bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaGabriela.saldo);
            Console.WriteLine("Resultado transferencia : " + resultadoTransferencia);

            contaGabriela.Transferir(100, contaBruno);
            Console.WriteLine("Saldo do bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela : " + contaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
