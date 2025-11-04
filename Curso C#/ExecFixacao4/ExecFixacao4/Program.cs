// Exercício de fixação;

// Exerciício 01
// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

// Primeiro declara a primeira classe, chamada pessoa.

using Exercicio4;
using System;

namespace Exercicio4
{
    class Pessoa
    {
        public string sNome;
        public int iIdade;
    }
}

// Declarar a classe Program para iniciar o programa.

namespace Course
{
    class Program { 
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.sNome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.iIdade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.sNome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.iIdade = int.Parse(Console.ReadLine());

            // Condição para o programa imprimir na tela quem é a pessoa
            // mais velha.

            if (p1.iIdade > p2.iIdade)
            {
                Console.WriteLine("Pessoa mais velha" + p1.sNome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.sNome);
            }
        }
    }
}


