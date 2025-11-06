// Estrutura repetitiva, para, que é o FOR.

// Degub feito

// Exercício:

// Digitar um número N e depois N valores inteiros. Mostrar a soma
// dos N valores digitados.

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int iNums = int.Parse(Console.ReadLine());

            int iSoma = 0;

            for (int i = 1; i <= iNums; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int iValor = int.Parse(Console.ReadLine());
                iSoma += iValor;
            }
            Console.WriteLine("Soma = " + iSoma);
        }
    }
}