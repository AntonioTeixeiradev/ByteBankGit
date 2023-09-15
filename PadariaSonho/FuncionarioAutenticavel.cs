using PadariaSonho.Funcionarios;
using PadariaSonho.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho
{
    public abstract class FuncionarioAutenticavel : Funcionario , IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(Double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
