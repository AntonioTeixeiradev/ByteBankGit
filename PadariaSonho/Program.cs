using PadariaSonho.Funcionarios;
using PadariaSonho.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContadorBonificacao();
            ContadorAumentos();

            Console.ReadLine();
        }

        public static void ContadorBonificacao()
        {
            Console.WriteLine("Iniciando processo de cadastros e obtendo total de bonificacoes...");

            GerenciadorDeBonus gerenciadorDeBonus = new GerenciadorDeBonus();

            Padeiro ze = new Padeiro("154.265.147-89");
            ze.Nome = "Ze";

            Gerente ricardo = new Gerente("458.245.398-87");
            ricardo.Nome = "Ricardo";

            Atendente otavio = new Atendente("547.258.145-96");
            otavio.Nome = "Otavio";

            gerenciadorDeBonus.CadastrarBonus(ze);
            gerenciadorDeBonus.CadastrarBonus(ricardo);
            gerenciadorDeBonus.CadastrarBonus(otavio);

            Console.WriteLine("Total de bonificacoes pagas : " + gerenciadorDeBonus.GetTotalBonificacao());
            Console.WriteLine("Numero de funcionarios cadastrados : " + Funcionario.ContadorFuncionario);
        }

        public static void ContadorAumentos()
        {

            Console.WriteLine("iniciando processo de cadastros e obtendo total de aumentos ...");

            GerenciadorDeAumentos gerenciadorDeAumentos = new GerenciadorDeAumentos();

            Padeiro ze = new Padeiro("154.265.147-89");
            ze.Nome = "Ze";

            Gerente ricardo = new Gerente("458.245.398-87");
            ricardo.Nome = "Ricardo";
            ricardo.Senha = "862";

            Atendente otavio = new Atendente("547.258.145-96");
            otavio.Nome = "Otavio";

            Proprietario joao = new Proprietario();
            joao.Senha = "258";


           
            gerenciadorDeAumentos.CadastrarAumento(ze);
            gerenciadorDeAumentos.CadastrarAumento(ricardo);
            gerenciadorDeAumentos.CadastrarAumento(otavio);

            Console.WriteLine("Total pago em aumentos foi de : " + gerenciadorDeAumentos.AumentoTotalAnual());

            SistemaInterno sistemaInterno = new SistemaInterno();

            Console.WriteLine("Testando validacoes ao sistema interno");

            sistemaInterno.Logar(ricardo, "862");
            sistemaInterno.Logar(joao, "458");
            sistemaInterno.Logar(joao, "258");

        }
    }
}
