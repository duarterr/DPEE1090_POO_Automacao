using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Calculadora calc = new Calculadora();

            double Circunferencia = calc.Circunferencia(Raio);
            double Volume = calc.Volume(Raio);

            Console.WriteLine("Circunferencia: " + Circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}