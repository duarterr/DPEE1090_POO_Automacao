namespace Course
{
    internal class Triangulo
    {
        // Atributos do triangulo - Lados A, B e C (double)
        public double A;
        public double B;
        public double C;

        // Método para cálculo da área - Foi delegado para a classe
        public double Area()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}
