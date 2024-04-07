using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de um objeto Pessoa a partir da classe Pessoa
            Pessoa pessoa1 = new Pessoa("Rodolfo", 2);
            Pessoa pessoa2 = new Pessoa("Rodolfo", 2);

            // Comparação manual
            Console.WriteLine(pessoa1.Nome == pessoa2.Nome && pessoa1.Idade == pessoa2.Idade);

            // Comparação usando o método Equals da classe pessoa
            Console.WriteLine(pessoa1.Equals(pessoa2));
        }
    }
}