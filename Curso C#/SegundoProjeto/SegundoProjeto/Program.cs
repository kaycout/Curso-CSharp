using System;
using System.Globalization;

namespace SegundoProjeto
{
    class DadosBasicos
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            // é indicado colocar a letra L no final
            // quando trabalha com a váriavel long.
            long n4 = 2147483648L;
            float n5 = 4.5f; // para declarar número em float, precisa colocar a letra f.
            double n6 = 4.5;
            string nome = "Kaylane Coutinho";
            // adicionando um novo nome a váriavel string.
            nome = "Alexandre";

            // váriavel object, é um tipo genérico, ou seja, aceita qualquer tipo de dados.

            object obj1 = "Patrícia Silva";
            object obj2 = 4.5f;
            
            // operador para incrementar o valor da váriavel.

            n1++;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // Exemplo com valores mínimo e máximo de cada váriavel.

            int max = int.MinValue;
            int max2 = int.MaxValue;
            sbyte min = sbyte.MinValue;
            decimal max3 = decimal.MaxValue;

            Console.WriteLine(max);
            Console.WriteLine(max2);
            Console.WriteLine(min);
            Console.WriteLine(max3);

        }
    }
}