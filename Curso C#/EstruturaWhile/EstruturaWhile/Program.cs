// Estrutura repetitiva enquanto (While).

// debug feito

using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double dNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (dNum >= 0.0)
            {
                double raiz = Math.Sqrt(dNum);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                dNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo.");
        }
    }
}