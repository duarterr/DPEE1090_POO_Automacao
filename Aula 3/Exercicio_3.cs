using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Exercício 3
            // ------------------------------------------------------------------------------------------ //

            Console.Write("Digite N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Divide a string recebida em um array de strings separadas no espaço
                string[] line = Console.ReadLine().Split(' ');

                double n1 = double.Parse(line[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(line[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (n1*2 + n2*3 + n3*5)/10;
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}