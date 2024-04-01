using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis para os lados dos triangulos
            double xA, xB, xC, yA, yB, yC;

            // Pega com usuario medidas do triangulo X
            Console.WriteLine("Digite as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Pega com usuario medidas do triangulo Y
            Console.WriteLine("Digite as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calulo da area de X
            double p = (xA + xB + xC)/2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            // Calculo da area de Y
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            // Exibicao dos resultados
            Console.WriteLine("Area do triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("O triângulo de maior area é " + (areaX > areaY ? "X" : "Y"));
        }
    }
}