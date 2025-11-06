// Exercício de matrizes

// fazer um programa para ler um numero inteiro N e uma
// matriz em ordem N contendo numeros inteiros. E logo depois
// mostrar a diagonal e a quantidade de valores negativos na matriz.


using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int iN = int.Parse(Console.ReadLine());

            int[,] mat  = new int[iN, iN];

            // percorre as linhas
            for (int i = 0; i < iN; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                // percorre as colunas
                for (int j = 0; j < iN; j++)
                {

                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < iN; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < iN; i++)
            {
                for (int j = 0; j < iN; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);


        }
    }
}
