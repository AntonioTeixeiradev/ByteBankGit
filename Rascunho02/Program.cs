using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascunho02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno antonio = new Aluno();

            antonio.nome = "Antonio Teixeira";
            antonio.genero = "masculino";
            antonio.peso = "80";

            antonio.morada = new Morada();
            antonio.morada.rua = "Rua Luis Soares Barboasa";
            antonio.morada.distrito = "Braga";
            antonio.morada.pais = "Portugal";



            Console.WriteLine("Nome : " + antonio.nome);
            Console.WriteLine("Genero : " + antonio.genero);
            Console.WriteLine("Peso : " + antonio.peso);
            Console.WriteLine("Reside em : " + antonio.morada.rua + " - " + antonio.morada.distrito + " - " + antonio.morada.pais);







            Console.ReadLine();
        }
    }
}
