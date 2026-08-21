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
            // Estrutura repetitiva while – Enquanto
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine("Estrutura repetitiva while");

            int n1 = 1;

            // Executa comandos dentro das chaves enquanto numero for maior que 0
            while (n1 > 0)
            {
                Console.Write("Digite um numero inteiro: ");
                n1 = int.Parse(Console.ReadLine());

                double raizQuadrada = Math.Sqrt(n1);
                Console.WriteLine(raizQuadrada.ToString("F4", CultureInfo.InvariantCulture));
            }

            // ------------------------------------------------------------------------------------------ //
            // Estrutura repetitiva do-while
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine("Estrutura repetitiva do-while");

            int n2 = 0;

            // Primeira execução ocorre mesmo com n2 = 0.
            // Depois, executa comandos dentro das chaves enquanto numero for maior que 0
            do
            {
                Console.Write("Digite um numero inteiro: ");
                n2 = int.Parse(Console.ReadLine());

                double raizQuadrada = Math.Sqrt(n2);
                Console.WriteLine(raizQuadrada.ToString("F4", CultureInfo.InvariantCulture));
            } while (n2 > 0);

            // ------------------------------------------------------------------------------------------ //
            // Estrutura repetitiva for
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine("Estrutura repetitiva for");

            int[] array = { 1, 20, 3, 45, 52 };

            // Laço executa 5 vezes, com i variando de 0 a 4
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }

            // ------------------------------------------------------------------------------------------ //
            // Estrutura repetitiva foreach
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine("Estrutura repetitiva foreach");

            // Laço executa 5 vezes, com i assumindo os valores de cada item no array
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}