using System.Globalization;

namespace ExecFixacao7
{
    internal class Produto
    {
        public string sNome;
        public double dPreco;
        public double iQuantidade;

        public Produto(string nome, double preco, double quantidade)
        {
            sNome = nome;
            dPreco = preco;
            iQuantidade = quantidade;
        }

        public double dValorTotalEmEstoque()
        {
            return dPreco * iQuantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {
            iQuantidade = iQuantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            iQuantidade = iQuantidade - quantidade;
        }

        public override string ToString()
        {
            return sNome
                + ", $ "
                + dPreco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + iQuantidade
                + " unidades, Total: $ "
                + dValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
