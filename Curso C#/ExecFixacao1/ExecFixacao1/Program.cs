//Programa em C# - Primeiro exercício de Fixação.

// foi feito o debug e funcionou

using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    class Exercicio
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome Completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura");
            string[] frase = Console.ReadLine().Split(' ');
            
            
            string ultimoNome = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2], CultureInfo.InvariantCulture);

            //chamando as variáveis declaradas.

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}





