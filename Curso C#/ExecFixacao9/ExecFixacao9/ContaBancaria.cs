using System.Globalization;

namespace ExecFixacao9
{
    internal class ContaBancaria
    {
        public int iNumero {  get; private set; }
        public string sTitular { get; set; }
        public double dSaldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            iNumero = numero;
            sTitular = titular;
        }

        public ContaBancaria( int numero, string titular, double depositoInicial ) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double dQuantia)
        {
            dSaldo += dQuantia;
        }

        //void porque não retorna nada. 
        //para sacar dinheiro tem uma taxa de R$ 5,00.
        public void Saque (double dQuantia)
        {
            dSaldo -= dQuantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + iNumero
                + ", Titular: "
                + sTitular
                + ", Saldo: $ "
                + dSaldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
