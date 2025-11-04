// Fazer um programa para ler os dados de um produto em estoque 
// (nome, preço e quantidade no estoque).

// Mostrar os dados do produto (nome, preço, quantidade no estoque, valor
// total no estoque).

// Realizar uma entrada no estoque e mostrar novamente os dados do produto.
// Realizar uma saída no estoque e mostrar novamente os dados do produto.

// Neste exercício, será necessário criar uma classe.

using ExecFixacao5;
using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main (string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.sNome = Console.ReadLine();
            Console.Write("Preço: ");
            p.dPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.iQuantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int iQntd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(iQntd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            iQntd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(iQntd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
