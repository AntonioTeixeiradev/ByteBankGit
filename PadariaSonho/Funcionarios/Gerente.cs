using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho.Funcionarios
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Gerente criado!");
        }

        public override double AumentoAnual()
        {
            return Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.14;
        }
    }

   
}
