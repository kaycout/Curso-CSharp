// OPERADORES ARITMÉTICOS.

using System;

namespace Operadores2
{
    class OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            double n4 = (double) 10 / 8;
            // ou double n4 = 10.0 / 8.
            Console.WriteLine(n4);

        }
    }
}