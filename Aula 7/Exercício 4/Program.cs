using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 + j0
            NumeroComplexo n1 = new NumeroComplexo(1);

            // 2 + j3
            NumeroComplexo n2 = new NumeroComplexo(2, 3);

            // 2 + j3
            NumeroComplexo n3 = new NumeroComplexo(2, 3);

            // Teste do método ToString
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            // Teste de igualdade
            Console.WriteLine("n1 e n2 são " + (n1.Equals(n2) ? "iguais" : "diferentes"));
            Console.WriteLine("n2 e n3 são " + (n2.Equals(n3) ? "iguais" : "diferentes"));

            // Teste dos métodos de soma e subtração
            n1.Soma(n2); // Agora n1 deve ter o valor de n1 + n2
            n2.Subtracao(n3); // Agora n2 deve ter o valor de n2 - n3
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            // Teste dos getters e setters
            n1.Real = 20;
            Console.WriteLine(n1.Real);

            n2.Imag = 10;
            Console.WriteLine(n2.Imag);

        }
    }
}