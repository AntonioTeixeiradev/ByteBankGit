using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando gerente de conta");
        }

        public override void AumentarSalario()
        {
            Salario = Salario + Salario * 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
