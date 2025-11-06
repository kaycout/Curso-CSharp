// Vetores

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN = int.Parse(Console.ReadLine());

            double[] dVetor = new double[iN];

            for (int i = 0; i < iN; i++)
            {
                dVetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double dSoma = 0.0;
            for (int i = 0; i < iN; i++)
            {
                dSoma += dVetor[i];
            }

            double dMedia = dSoma / iN;

            Console.WriteLine("Altura média = " + dMedia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}