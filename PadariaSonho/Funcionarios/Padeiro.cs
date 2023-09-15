using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho.Funcionarios
{
    public class Padeiro : Funcionario
    {
        public Padeiro(string cpf) : base(2500, cpf)
        {
            Console.WriteLine("Padeiro criado!");
        }

        public override double AumentoAnual()
        {
            return Salario *= 0.06;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.14;
        }
    }
}
