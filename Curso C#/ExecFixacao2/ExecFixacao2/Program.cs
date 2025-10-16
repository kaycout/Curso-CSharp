//Programa em C# - Segundo Exercício de Fixação.

// feito o debug 

using System;
using System.Globalization;

namespace SegundoExercicio
{
    class Exercicio2
    {
        static void Main(string[] args)
        {

            string produto1 = "Notebook";
            string produto2 = "Escrivaninha";

            byte idade = 30;
            int codigoProduto = 5345;
            char genero = 'M';

            double preco1 = 3500.0;
            double preco2 = 700.90;
            double medida = 54.234565;

            Console.WriteLine("Produtos:");
            // Placeholder
            // {1:F2} para diminuir casas decimais.
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);

            // Concatenação
            Console.WriteLine("Registro:");
            Console.WriteLine(idade + " anos de idade, código " + codigoProduto + " e gênero: " + genero);

            // Para imprimir a variavel "medida" com 8 casas decimais.

            Console.WriteLine("Medidas com oito casa decimais:");
            Console.WriteLine(medida.ToString("F8"));

            // Para imprimir apenas com 3 casa decimais.
            Console.WriteLine("Arredondado (três casas decimais):");
            Console.WriteLine(medida.ToString("F3"));

            // Para imprimir separando as casas decimais com "."
            Console.WriteLine("Separador decimal invariant culture:");
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}