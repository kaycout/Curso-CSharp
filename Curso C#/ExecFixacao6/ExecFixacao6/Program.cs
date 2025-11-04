// Membros estáticos 

// chamados de membros de "Classe"

// São membros que fazem sentido independentemente 
// de objetos e nao precisam de objeto para serem chamados. Pois,
// são chamados pelo próprio nome da classe.


// Fazer um programa para ler um valor numerico e mostrar
// quanto seria o valor de uma circunferencia, volume e raio. Além de informar o
// valor de PI com duas casas decimais.

using ExecFixacao6;
using System.Globalization;

namespace Exercicio6
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double dRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(dRaio);
            double vol = Calculadora.Volume(dRaio);


            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.dPi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
