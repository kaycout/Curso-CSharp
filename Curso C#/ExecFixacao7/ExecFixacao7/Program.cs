// Exercício Construtor

// Construtor é uma operação de classe que executa o comando
// no momento da instanciação do objeto.

// Inicia os valores dos atributos
// permite ou obriga o objeto a receber dados

using ExecFixacao7;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string sNome = Console.ReadLine();
            Console.Write("Preço: ");
            double dPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int iQuantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(sNome, dPreco, iQuantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int iQntd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(iQntd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            iQntd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(iQntd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }
}
