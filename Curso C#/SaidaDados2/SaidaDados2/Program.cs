// Saída de dados em C#

using System;

//namespace para imprimir números com pontos para separação de casas.
using System.Globalization;

namespace SegundoExercicio
{
    class Exercicio
    {
        static void Main(string[] args)
        {

            // Declarando variáveis
            char genero = 'F';
            int idade = 18;
            double saldo = 10.38844;
            string nome = "Maria";

            Console.WriteLine("Primeiros programas em C#");
            Console.WriteLine("Aprendendo passo a passo os comandos em C#");
            Console.WriteLine("Espero muito consegue aprender com esses exercícios");
            Console.WriteLine("----------------------------------------------------------------");

           // Chamando as variáveis
           Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            //Para imprimir somente 2 casas decimais da variável SALDO.
            Console.WriteLine(saldo.ToString("F2"));

            //Para imprimir com o . separador
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Diferença entre Write e WriteLine
            // Write imprime a mensagem no terminal e não quebra linha.
            // WriteLine imprime a mensagem no terminal, quebra a linha
            // e escreve a mensagem logo abaixo. 

        }
    }
}