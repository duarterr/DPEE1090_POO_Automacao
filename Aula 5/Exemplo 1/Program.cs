using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de um objeto Pessoa a partir da classe Pessoa
            Pessoa pessoa1 = new Pessoa("Rodolfo", 2);

            Console.WriteLine($"pessoa1: Nome = {pessoa1.Nome}, Idade = {pessoa1.Idade}");

            // Declaração de nova pessoa com dados de pessoa1
            Pessoa pessoa2 = pessoa1;

            // Mudança de dados de pessoa2
            pessoa2.Nome = "Berenice";
            pessoa2.Idade = 4;

            Console.WriteLine($"pessoa2: Nome = {pessoa2.Nome}, Idade = {pessoa2.Idade}");

            // Dados de pessoa1 também mudaram
            Console.WriteLine($"pessoa1: Nome = {pessoa1.Nome}, Idade = {pessoa1.Idade}");
        }
    }
}