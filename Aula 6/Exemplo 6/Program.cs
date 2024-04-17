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

            // Alteração do saldo só é possível com depósito ou saque
            conta.Deposito(1000);
            //conta.Saldo = 1000; // Invalido pois SET da propriedade Saldo é privado

            // Exibição do saldo com getter da propriedade Saldo
            Console.WriteLine("Saldo: " + conta.Saldo.ToString("F2"));
        }
    }
}