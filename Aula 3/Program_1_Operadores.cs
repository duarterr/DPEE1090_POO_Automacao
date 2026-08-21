using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Operadores aritmeticos
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine("Operadores aritmeticos");

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 / 3;
            int n4 = 17 % 3;

            double n5 = Math.Pow(2.0, 3.0); // 2^3

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            // ------------------------------------------------------------------------------------------ //
            // Operadores de atribuição
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine();
            Console.WriteLine("Operadores de atribuicao");

            int n6 = 10;
            Console.WriteLine(n6);

            n6 += 2;
            Console.WriteLine(n6);

            n6 *= 3;
            Console.WriteLine(n6);

            string str = "ABC";
            Console.WriteLine(str);

            str += "DEF";
            Console.WriteLine(str);

            // ------------------------------------------------------------------------------------------ //
            // Operadores postfix e prefix
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine();
            Console.WriteLine("Operadores postfix e prefix");

            int n7 = 1;
            Console.WriteLine(n7++);    // Retorna 1 depois soma 1
            Console.WriteLine(n7);      // 2

            Console.WriteLine(n7--);    // Retorna 2 depois diminui 1   
            Console.WriteLine(n7);      // 1

            Console.WriteLine(++n7);    // Soma 1 depois retorna 2
            Console.WriteLine(n7);      // 2

            Console.WriteLine(--n7);    // Diminui 1 depois retorna 1
            Console.WriteLine(n7);      // 1

            // ------------------------------------------------------------------------------------------ //
            // Operadores comparativos
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine();
            Console.WriteLine("Operadores comparativos");

            Console.WriteLine(10 > 11);
            Console.WriteLine(10 < 11);
            Console.WriteLine(11 >= 11);
            Console.WriteLine(10 <= 11);
            Console.WriteLine(10 == 11);
            Console.WriteLine(10 != 11);

            // ------------------------------------------------------------------------------------------ //
            // Operadores logicos
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine();
            Console.WriteLine("Operadores logicos");

            Console.WriteLine(true || false && !false);     // True
            Console.WriteLine((true || false) && !true);    // False

            // ------------------------------------------------------------------------------------------ //
            // Conversão implicita e casting
            // ------------------------------------------------------------------------------------------ //

            Console.WriteLine();
            Console.WriteLine("Conversao implicita e casting");

            float n8 = 1.25F;
            double n9 = n8;     // Conversao implicita possivel pois tamanho de double é maior que de float

            Console.WriteLine(n8);
            Console.WriteLine(n9);
            
            //float n10 = n9;   // Conversao invalida pois um float não consegue armazenar todos os bytes de um double
            float n10 = (float)n9;  // Casting de variável. Forçamos n9 a "caber" em 4 bytes. Pode haver perda de dados
            Console.WriteLine(n10);

            //int n11 = n8;   // Invalido pois tipos não suportam conversão implícita. Necessário casting
            int n11 = (int)n8;  // Casting de float para int. Há perdade dados (valores após a virgula)
            Console.WriteLine(n11);

            // ------------------------------------------------------------------------------------------ //

            int a = 10;
            int b = 3;
            double c = a / b;

            Console.WriteLine(c);

            double d = (double)a / b;

            Console.WriteLine(d);
        }
    }
}