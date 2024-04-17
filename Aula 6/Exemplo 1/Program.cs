using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A circunferencia vale: " + Calculadora.Circunferencia1(Raio));
            Console.WriteLine("A circunferencia vale: " + Calculadora.Circunferencia2(Raio));
        }
    }
}