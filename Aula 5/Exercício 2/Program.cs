using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Digite a quantidade de dólares a ser comprada: ");
            double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Reais = ConversorDeMoeda.DolarParaReal(Quantidade, Cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + Reais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}