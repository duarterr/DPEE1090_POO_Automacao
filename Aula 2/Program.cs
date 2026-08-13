using System;
using System.Globalization;

namespace ProjetoBases
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Tipos valor
            // ------------------------------------------------------------------------------------------ //

            bool completo = false; 
            char genero = 'F'; 
            char letra = '\u0041'; 
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647; 
            long n4 = 2147483648L;
            float n5 = 4.5f; 
            double n6 = 4.5;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            // ------------------------------------------------------------------------------------------ //
            // Tipos referência
            // ------------------------------------------------------------------------------------------ //

            String nome = "Maria"; 
            Object obj1 = "Alex"; 
            Object obj2 = 4.5f;

            Console.WriteLine(nome); 
            Console.WriteLine(obj1); 
            Console.WriteLine(obj2);

            // ------------------------------------------------------------------------------------------ //
            // Saída de dados em C#
            // ------------------------------------------------------------------------------------------ //

            double x = 2.455245;
                        
            Console.WriteLine("O valor de x é " + x + " reais");    // Concatenação
            Console.WriteLine("O valor de x é {0} reais", x);       // Placeholder
            Console.WriteLine($"O valor de x é {x} reais");         // Interpolação

            // Formatando numero de casas decimais
            Console.WriteLine("O valor de x é " + x.ToString("F2") + " reais");

            // Formatando separador decimal
            Console.WriteLine("O valor de x é " + x.ToString(CultureInfo.InvariantCulture) + " reais");

            // ------------------------------------------------------------------------------------------ //
            // Entrada de dados em C#
            // ------------------------------------------------------------------------------------------ //

            string valor = Console.ReadLine();
            Console.WriteLine(valor);

            int valorInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine(valorInteiro);

            double valorDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(valorDouble);

            double valorDouble2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(valorDouble2);
        }
    }
}