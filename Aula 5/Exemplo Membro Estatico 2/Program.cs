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

            double Circunferencia = Calculadora.Circunferencia(Raio);
            double Volume = Calculadora.Volume(Raio);

            Console.WriteLine("Circunferencia: " + Circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}