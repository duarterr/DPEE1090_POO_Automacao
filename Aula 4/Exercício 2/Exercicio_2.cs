using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetos triangulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            // Pega com usuario medidas do triangulo X e salva nos atributos do objeto X
            Console.WriteLine("Digite as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Pega com usuario medidas do triangulo Y e salva nos atributos do objeto Y
            Console.WriteLine("Digite as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calulo da area de X
            double p = (x.A + x.B + x.C)/2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            // Calculo da area de Y
            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            // Exibicao dos resultados
            Console.WriteLine("Area do triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("O triângulo de maior area é " + (areaX > areaY ? "X" : "Y"));
        }
    }
}