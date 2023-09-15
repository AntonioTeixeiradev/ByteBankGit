using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDadosGinasio
{
    class Aluno

    {
        public Aluno()
        {
            contadorCadastro++;
        }


        public static int contadorCadastro { get; private set; }

        public string nome;

        public int numeroAluno;
  

        public string genero;

        public Medidas medidas;

        public string turno;

        public string cpf;

        public Morada morada;

        public Contactos contactos;

        private double vale = 100;

        public string modalidade;

        public double imc;

        //VERIFICANDO IMC DO ALUNO
        public double VerificarImc()
        {
            imc = medidas.peso / (medidas.altura * medidas.altura);
            return imc;

        
        }

        //METODO QUE VERIFICA SE ESTA PERMITIDO ENTRAR NA AREA DE LUTA
        public void AcessarAreaDeLuta()
        {
            var modalidadesDeLuta = new[] { "box", "judo" };

            for (int i = 0; i < modalidadesDeLuta.Length; i++)
            {
                var modalidadeDeLuta = modalidadesDeLuta[i];

                if (this.modalidade == modalidadeDeLuta)
                {
                    Console.WriteLine(this.nome + " Acesso na area de luta permitido.");
                    return;
                }
                
                               
            }
            Console.WriteLine("Acesso na area de luta negado");

        }


        public double Vale
        {
            get
            {
                return vale;
            }
            set
            {
                vale = value;
            }
        }

    } 

    class Morada
    {
        public string rua;
        public int numero;
        public string distrito;
        public string pais;
    }

    class Contactos
    {
        public double telemovel;
        public string email;
    }

    class Medidas
    {
        public int peso;
        public double altura;
        public double circAbdomem;

    }
    





}
