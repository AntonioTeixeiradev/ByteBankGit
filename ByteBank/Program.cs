using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("584.298.456-9");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("524.295.187-8");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Designer pedro = new Designer("458.256.125-4");
            pedro.Nome = "Pedro";

            PareceiroComercial roberto = new PareceiroComercial();
            roberto.Senha = "456";

            sistemaInterno.Logar(roberto, "456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Funcionario pedro = new Designer("458.256.125-4");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("584.298.456-9");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("457.269.454-4");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("524.295.187-8");
            camila.Nome = "Camila";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificacaos do mes :" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
