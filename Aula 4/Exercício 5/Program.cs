using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetos pessoa - Instanciação dessa forma não funciona pois construtor precisa de parametros
            //Pessoa pessoa1 = new Pessoa();
            //Pessoa pessoa2 = new Pessoa();

            // Pega dados da primeira pessoa e salva no objeto pessoa1
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Declara e instancia pessoa1 com construtor
            Pessoa pessoa1 = new Pessoa(nome, idade);

            // Pega dados da segunda pessoa e salva no objeto pessoa2
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            // Declara e instancia pessoa1 com construtor
            Pessoa pessoa2 = new Pessoa(nome, idade);

            // Mostra nome da pessoa  mais velha
            Console.WriteLine("Pessoa mais velha: " + (pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome));
        }
    }
}