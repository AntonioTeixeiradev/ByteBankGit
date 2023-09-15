using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho.Funcionarios
{
    public class Atendente : Funcionario
    {
        public Atendente(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Atendente criado!");
        }

        public override double AumentoAnual()
        {
            return Salario *= 0.07;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.13;
        }
    }
}
