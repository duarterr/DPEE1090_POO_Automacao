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
            Pessoa pessoa2 = new Pessoa("Berenice", 4);

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
        }
    }
}