// Conversão implicita e casting
// ------------------------------------------
// - Converter um tipo de dado para outro
//   significa alterar o formato do valor,
//   por exemplo, de double para float, ou
//   de double para int. 

// Exemplo de conversão.

using System;

namespace Conversao
{
    class ConversaoOperadores
    {
        static void Main(string[] args)
        {

            double a;
            float b;

            a = 5.1;
            // Para realizar a conversão
            // de double para float é necessário
            // fazer um casting, pois pode ocorrer
            // perda de informação.
            b = (float)a;

            Console.WriteLine(b);

            // ------------------------------------
            // Exemplo com DOUBLE e INT

            double c;
            int d;

            c = 5.1;
            // Só é possível converter para int
            // se fizer o casting. Porém, pode ocorrer
            // perda de dados (a parte decimal é descartada).
            d = (int)c;

            Console.WriteLine(d);

            // ------------------------------------
            // Este exemplo não é válido, pois
            // tanto o valor de a, como o valor de b,
            // são do tipo INT. O compilador entende
            // que a expressão a / b deve ser feita
            // considerando apenas valores inteiros.
            // Para garantir que o resultado seja
            // decimal, é preciso fazer o casting.

            int e = 5;
            int f = 2;

            double resultado = e / f;

            // double resultado = (double)e / f;
            // Desta forma, o valor será impresso corretamente.

            Console.WriteLine(resultado);
        }
    }
}
