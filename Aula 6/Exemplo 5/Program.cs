using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de um objeto "conta"
            Conta conta = new Conta("Astolfo", 0);

            // Alteração do saldo com setter da propriedade Saldo
            conta.Saldo = 1000;

            // Exibição do saldo com getter da propriedade Saldo
            Console.WriteLine("Saldo: " + conta.Saldo.ToString("F2"));
        }
    }
}