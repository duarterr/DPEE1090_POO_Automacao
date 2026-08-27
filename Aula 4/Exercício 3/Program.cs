using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetos pessoa
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            // Pega dados da primeira pessoa e salva no objeto pessoa1
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            // Pega dados da segunda pessoa e salva no objeto pessoa2
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            // Mostra nome da pessoa  mais velha
            Console.WriteLine("Pessoa mais velha: " + (pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome));
        }
    }
}