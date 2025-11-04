namespace ExecFixacao6
{
    internal class Calculadora
    {
         public static double dPi = 3.14;

        public static double Circunferencia(double dR)
        {
            return 2.0 * dPi * dR;
        }

        public static double Volume(double dR)
        {
            return 4.0 / 3.0 * double.Pi * dR * dR * dR;

        }
    }
}
