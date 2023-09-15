using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool funcionarioAutenticado = funcionario.Autenticar(senha);
               
            if (funcionarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema interno ");
                return true;
            }
            else
            {
                Console.WriteLine("Acesso ao sistema interno negado");
                return false;
            }


        }
    }
}
