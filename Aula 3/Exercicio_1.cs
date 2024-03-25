using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Exercicio 1
            // ------------------------------------------------------------------------------------------ //

            Console.Write("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o terceiro numero: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Numero 1 é par: " + ((n1 % 2) == 0));
            Console.WriteLine("Numero 2 é par: " + ((n2 % 2) == 0));
            Console.WriteLine("Numero 3 é par: " + ((n3 % 2) == 0));

            double soma = n1 + n2 + n3;
            double media = soma / 3;

            Console.WriteLine("A soma é: " + soma.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("A média é: " + media.ToString(CultureInfo.InvariantCulture));
        }
    }
}