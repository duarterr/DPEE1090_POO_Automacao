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

            // Exibição dos dados
            Console.WriteLine(conta);

            // Deposito inicial de 1000 dinheiros
            conta.Deposito(1000);
            Console.WriteLine(conta);

            // Tentativa de saque inválida pois não há saldo
            conta.Saque(20000);
            Console.WriteLine(conta);

            // Manipulação direta do atributo "saldo" - Objeto perde a consistência pois saldo só poderia ser aumentado através de um depósito
            conta.Saldo = 100000000;

            // Agora tentativa de saque é valida pois "criou-se" saldo sem um depósito
            conta.Saque(20000);
            Console.WriteLine(conta);

        }
    }
}