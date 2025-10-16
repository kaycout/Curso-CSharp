// Estrutura condicional - IF - ELSE.

// foi feito o debug

// uma estrutura simples contém apenas a condição IF.

// já uma estrutura composta contém as condições IF-ELSE.

// agora, uma estrutura com encadeamentos, contém IF, ELSE E ELSE-IF.

using System;

namespace Condicao
{
    class Estrutura
    {
        static void Main(string[] args)
        {

            int iValor = 10;

            Console.WriteLine("Bom dia Kaylane");

            // Esse bloco que está entre {} só irá ser executado quando 
            // a condição for verdadeira.
            if (iValor > 20) {
                Console.WriteLine("Boa tarde galera do meu canal");

            }
            Console.WriteLine("Boa noite Pessoal");

            // Programinha simples. Entrar com um número e pedir 
            // para o usuário digitar um valor e o programa
            // vai ter que falar se é ímpar ou par.
            
            // Estrutura composta

            Console.WriteLine("Entre com um número inteiro: ");

            int iNumero = int.Parse(Console.ReadLine());

            // se iNumero for divisivel por 2 e o resto da divisão
            // for igual a 0, o número é par.
            if (iNumero % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

            // Encadeamentos de várias estruturas condicionais.

            Console.WriteLine("Qual a hora atual? ");

            int iHora = int.Parse(Console.ReadLine());

            if (iHora < 12)
            {
                Console.WriteLine("Bom dia Kaylane! ");
            }
            else if (iHora < 18)
            {
                Console.WriteLine("Boa tarde Kaylane! ");
            }
            else
            {
                Console.WriteLine("Boa noite Kaylane! ");
            }

        }
    }
}


