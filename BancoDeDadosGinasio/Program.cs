using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDadosGinasio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco de Dados - Ginasio Puro Osso. ");

            Aluno rafael = new Aluno();

            rafael.nome = "Rafael";
            rafael.medidas = new Medidas();
            rafael.medidas.peso = 118;
            rafael.medidas.altura = 1.75;






            Aluno geizi = new Aluno();

            geizi.nome = "Geizi";
            geizi.genero = "Feminino";
            geizi.medidas = new Medidas();
            geizi.medidas.altura = 1.69;
            geizi.medidas.peso = 68;
            geizi.modalidade = "Musculacao";
            

            Aluno magro = new Aluno();

            //INFORMACOES DE CADASTRO DO ALUNO MAGRO

            magro.nome = "Magro";
            magro.numeroAluno = 157;
            magro.genero = "Masculino";
            magro.turno = "Manha";
            magro.cpf = "123.123.123-12";

            magro.morada = new Morada();
            magro.morada.rua = "Rua da Zura";
            magro.morada.numero = 1;
            magro.morada.distrito = "Sao Magro";
            magro.morada.pais = "Magrolandia";

            magro.contactos = new Contactos();
            magro.contactos.telemovel = 987654321;
            magro.contactos.email = "magro@gmeiohomem.com";

            magro.medidas = new Medidas();
            magro.medidas.altura = 1.68;
            magro.medidas.peso = 89;
            magro.medidas.circAbdomem = 10;
            magro.modalidade = "box";

            //VERIFICANDO IMC DO ALUNO  

            magro.VerificarImc();
            
            

            if (magro.imc <= 18.5)
            {
                Console.WriteLine("Teste IMC : abaixo do peso");
            }

            //VERIFICACAO DE ENTRADA NA AREA DE LUTA 

            magro.AcessarAreaDeLuta();
            geizi.AcessarAreaDeLuta();


            //APRESENTACAO ALUNO NO CONSOLE

            //ALUNO MAGRO
            Console.WriteLine("Nome aluno : " + magro.nome);
            Console.WriteLine("Numero cadastro : " + magro.numeroAluno);
            Console.WriteLine("Genero : " + magro.genero);
            Console.WriteLine("Turno : " + magro.turno);
            Console.WriteLine("CPF : " + magro.cpf);
            Console.WriteLine("Morada : " + magro.morada.rua + "-" + magro.morada.numero +"-" + magro.morada.distrito +"-" + magro.morada.pais);
            Console.WriteLine("Numero telemovel : " + magro.contactos.telemovel);
            Console.WriteLine("Endereco de email : " + magro.contactos.email);
            magro.Vale = 150;
            Console.WriteLine("Saldo em vale : " + magro.Vale);

            //ALUNO TEM QUE TREINAR 1 DIA, E DESCANSAR O OUTRO, SEGUE ABAIXO SEUS DIAS DE TREINO:

            Console.WriteLine("Segue abaixo os dias de treino do aluno " + magro.nome);

            for (int x = 1; x <= 30; x += 2)
            {
                Console.WriteLine("Dia : " + x);
            }

            //ALERTAS DE SAUDE

            Console.WriteLine("Imc do aluno : " + magro.imc);

            if (magro.medidas.peso <= 55)
            {             
                Console.WriteLine("Alerta de saude, aluno " + magro.nome + " esta abaixo do peso minimo.");
            }

            if(magro.medidas.peso > 80)
            {
                Console.WriteLine("Alerta de saude, aluno " + magro.nome + " esta acima do peso. ");
            }

            if (magro.medidas.circAbdomem >= 15)
            {
                Console.Write("Alerta de saude, aluno " + magro.nome + " esta com tanquinho invalido");
            }

            if(magro.medidas.altura < 1.50)
            {
                Console.WriteLine("Alerta de saude, aluno " + magro.nome + " esta abaixo da altura minima");
            }

            Console.WriteLine("Nova aluna :" + geizi.nome);
            Console.WriteLine("O IMC é : " + geizi.VerificarImc());


            Console.WriteLine(" aluno :" + rafael.nome);
            Console.WriteLine(" o IMC é : " + rafael.VerificarImc());
            

            //CONTADOR DE CADASTRO
            Console.WriteLine("Numero de alunos cadastrados :" + Aluno.contadorCadastro);


            Console.ReadLine();
        }
    }
}
