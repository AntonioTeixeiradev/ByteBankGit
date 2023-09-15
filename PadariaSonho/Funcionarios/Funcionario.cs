using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int ContadorFuncionario { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando funcionario...");

            Salario = salario;

            CPF = cpf;

            ContadorFuncionario++;

        }

        public abstract double AumentoAnual();

        public abstract double GetBonificacao();

    }
}
