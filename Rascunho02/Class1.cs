using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascunho02
{
    internal class Aluno
    {
        public string nome;
        public string genero;
        public string peso;
        public Morada morada;
        public Modalidade modalidade;
        public Contactos contactos;
    }
    internal class Morada
    {
        public string rua;
        public string distrito;
        public string pais;
    }
    
    }
    internal class Modalidade
    {
        public string luta ;
        public string musculacao;
        public string cross;
        public string bike;
        public string natacao;

    }

    internal class Contactos
    {
        public string telemovel;
        public string email;
        public string telemovelParente;
    }
}