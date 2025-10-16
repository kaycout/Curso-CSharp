// Operadores Lógicos

// Código debugado. 

using System;

namespace OperadoresLogicos
{
    class Exercicio
    {
        static void Main(string[] args)
        {   
            // exemplo com a condição (E).
            // prefixo 'b' indica uma variável booleana(true ou false).
            // operador != significa "diferente".
            // > maior
            // && e.
            // essa condição precisa ser falsa, pois na condição (E)
            // é preciso que as duas condições sejam verdadeiras.
            bool bResultado =  2 > 3 && 4 != 5;

            // exemplo com a condição (OU).
            // essa condição tem que ser verdadeira, pois
            // 2 não é maior do que 3, mas o 4 é menor do que 5.
            // Ou seja, nesta condição, apenas 1 precisa necessariamente
            // ser verdadeira.
            bool bResultado2 = 2 > 3 || 4 != 5;

            //outro exemplo
            //  ! (NÃO).
            // Essa condição tem que dar verdadeira, pois
            // 2 não é maior do que 3 e 4 é menor do que 5.
            bool bResultado3 = !(2 > 3) && 4 != 5; 

            Console.WriteLine(bResultado);
            Console.WriteLine(bResultado2);
            Console.WriteLine(bResultado3);

            Console.WriteLine("----------------------------");

            bool bResultado4 = 10 < 5;

            // Nesta expressão, o operador E (&&) será avaliado antes do operador OU (||).
            // Como bResultado2 e bResultado3 são verdadeiros, essa parte resultará em verdadeiro.
            // Em seguida, esse resultado será comparado com bResultado (que é falso).
            // No final, a expressão completa será verdadeira, pois no operador OU (||),
            // basta que uma das condições seja verdadeira para o resultado ser verdadeiro.

            bool bResultado5 = bResultado || bResultado2 && bResultado3;

            Console.WriteLine(bResultado4);
            Console.WriteLine(bResultado5);



        }
    }
}