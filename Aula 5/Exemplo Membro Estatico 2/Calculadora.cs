namespace Course
{
    internal class Calculadora
    {
        // Valor de Pi
        public static double Pi = 3.1415;

        // Método para calcular a circunferência dado um raio
        public static double Circunferencia(double raio)
        {
            return 2.0*Pi*raio;
        }

        // Método para calcular o volume de uma esfera dado um raio
        public static double Volume(double raio)
        {
            return (4.0/3.0) * Pi * Math.Pow(raio, 3);
        }
    }
}
