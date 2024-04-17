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

            // Alteração do saldo com setter
            conta.SetSaldo(1000);

            // Exibição do saldo com getter
            Console.WriteLine("Saldo: " + conta.GetSaldo().ToString("F2"));
        }
    }
}