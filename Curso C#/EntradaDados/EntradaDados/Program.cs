// Entrada de dados em C# Parte - 1

// Console.ReadLine();

// Lê a entrada padrão 
// até reconhecer uma quebra de linha
// e retorna dados em string.

using System;
using System.Globalization;

namespace EntradaDados
{
    class Dados
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}






            