using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria invoice válida, com valores positivos
            Invoice inv1 = new Invoice(1234, "Monitor", 2, 1000);

            // Teste do método de impressão e também do GetInvoiceAmount
            Console.WriteLine(inv1.ToString());

            // Cria invoice inválida, com valores negativos
            Invoice inv2 = new Invoice(4567, "Mouse", -2, -10.0);
            Console.WriteLine(inv2.ToString());

            // Teste dos getters e setters não é necessário pois contrutor invoca os setters
            // e ToString invoca os getters
        }
    }
}