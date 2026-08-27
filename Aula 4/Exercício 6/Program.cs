using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pega dados da primeira pessoa e salva no objeto pessoa1
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Declara e instancia pessoa1 com construtor 1
            Pessoa pessoa1 = new Pessoa(nome, idade);

            // Pega dados da segunda pessoa e salva no objeto pessoa2
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Declara e instancia pessoa1 com construtor 2
            Pessoa pessoa2 = new Pessoa(nome, idade, altura);

            // Mostra nome da pessoa  mais velha
            Console.WriteLine("Pessoa mais velha: " + (pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome));

            // Exibe altura das duas pessoas
            Console.WriteLine(pessoa1.Altura);
            Console.WriteLine(pessoa2.Altura);
        }
    }
}