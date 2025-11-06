// funções - parte básica

// debug feito

// problema exemplo

// fazer um programa para ler três números inteiros e mostrar na tela o maior deles. 

using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");
            int iNum1 = int.Parse(Console.ReadLine());
            int iNum2 = int.Parse(Console.ReadLine());
            int iNum3 = int.Parse(Console.ReadLine());

            // Estrutura condicional 

            if (iNum1 > iNum2 && iNum1 > iNum3)
            {
                Console.WriteLine("Maior = " + iNum1);
            }
            else if (iNum2 > iNum3)
            {
                Console.WriteLine("Maior = " + iNum2);
            }
            else
            {
                Console.WriteLine("Maior = " + iNum3);
            }

            // Função responsável por identificar e retornar o
            // maior número entre os valores informados.

            double dResultado = Maior(iNum1, iNum2, iNum3);

            // ou seja, esse 'Maior' será uma função criada
            // para receber os valores de entrada e identificar o 'Resultado'
            // que será o maior dos três.  

            Console.WriteLine("Maior = " + dResultado);
        }

        static int Maior(int a, int b, int c) {
        int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

        }
    }
}