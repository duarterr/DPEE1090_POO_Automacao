namespace Course
{
    internal class Calculadora
    {
        // Valor de Pi - Constante
        public double Pi = 3.1415;

        // Método para calcular a circunferência dado um raio
        public double Circunferencia(double raio)
        {
            return 2.0*Pi*raio;
        }

        // Método para calcular o volume de uma esfera dado um raio
        public double Volume(double raio)
        {
            return (4.0/3.0) * Pi * Math.Pow(raio, 3);
        }
    }
}
