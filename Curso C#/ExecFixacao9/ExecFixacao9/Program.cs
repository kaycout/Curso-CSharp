using System;
using System.Globalization;

// Fazer um programa onde em um banco para se cadastrar é
// necessário informar o número da conta, nome do titular da conta
// e o valor de depósito inicial que o titular depositou ao abrir
// a conta.


using System;
using ExecFixacao9;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int iNumero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string sTitular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char sResp = char.Parse(Console.ReadLine());
            if (sResp == 's' || sResp == 'S' )
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double dDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(iNumero, sTitular, dDepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(iNumero, sTitular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double dQuantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(dQuantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            dQuantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(dQuantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}