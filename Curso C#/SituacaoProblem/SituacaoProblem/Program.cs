// Problema exemplo:

// fazer um programa para ler as medidas dos lados de dois triângulos 
// X e Y. Em seguida, mostrar o valor das áreas dos dois triângulos e dizer
// qual dos dois triângulos possui a maior área.

// A fórmula para calcular a área de um triângulo a partir das medidas de seus lados 
//a, b e c é a seguinte (fórmula de heron)

using System;
using System.Globalization;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {

            double dLadoA, dLadoB, dLadoC, dLadoD, dLadoE, dLadoF;
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            dLadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dLadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dLadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            dLadoD = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dLadoE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dLadoF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (dLadoA + dLadoB + dLadoC) / 2.0;
            double dAreaX = Math.Sqrt(p * (p - dLadoA) * (p - dLadoB) * (p - dLadoC));

            p = (dLadoA + dLadoB + dLadoC) / 2.0; 
            double dAreay = Math.Sqrt(p * (p -dLadoA) * (p - dLadoB) * (p - dLadoC));

            Console.WriteLine("Área de X = " + dAreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + dAreaX.ToString("F4", CultureInfo.InvariantCulture));

            if (dAreaX > dAreay)
            {
                Console.WriteLine("Maior área: X ");
            }
            else
            {
                Console.WriteLine("Maior área: Y ");
            }
        }
    }
}

