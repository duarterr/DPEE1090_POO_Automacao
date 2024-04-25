using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construtor 1 - Com valor padrão
            Triangle t = new Triangle();

            // Teste do getter - Valor padrão
            Console.WriteLine(t.GetSide());

            Console.WriteLine("---------------------------------");

            // Pega lado com usuario
            Console.Write("Digite o lado do triangulo: ");
            double Side = double.Parse(Console.ReadLine());

            // Teste do setter
            t.SetSide(Side);
            Console.WriteLine(t.GetSide());

            // Teste dos métodos area e perimeter
            Console.WriteLine("Area: " + t.Area());
            Console.WriteLine("Perimetro: " + t.Perimeter());


            Console.WriteLine("---------------------------------");
            
            // Teste do construtor 2
            Triangle t2 = new Triangle(Side);
            Console.WriteLine(t2.GetSide());
        }
    }
}