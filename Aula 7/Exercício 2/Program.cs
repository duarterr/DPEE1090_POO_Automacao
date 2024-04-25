using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pega lado com usuario
            Console.Write("Digite um CPF (somente numeros): ");
            string Entrada = Console.ReadLine();

            // Teste
            Console.WriteLine("CPF digitado é " + (Cpf.Valida(Entrada) ? "válido" : "inválido"));
        }
    }
}