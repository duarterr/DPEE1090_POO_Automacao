using System;
using System.Collections;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia dois objetos produto
            Produto produto1 = new Produto();
            Produto produto2 = new Produto();

            // Pega com usuário dados do produto 1
            Console.WriteLine("Digite os dados do produto 1: ");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();

            Console.Write("Código: ");
            produto1.Codigo = int.Parse(Console.ReadLine());
            
            Console.Write("Valor: ");
            produto1.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto1.Quantidade = uint.Parse(Console.ReadLine());

            // Pega com usuário dados do produto 2
            Console.WriteLine();
            Console.WriteLine("Digite os dados do produto 2: ");
            Console.Write("Nome: ");
            produto2.Nome = Console.ReadLine();

            Console.Write("Código: ");
            produto2.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Valor: ");
            produto2.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            produto2.Quantidade = uint.Parse(Console.ReadLine());

            // Imprime dados dos produtos
            Console.WriteLine();
            Console.WriteLine(produto1.ToString());
            Console.WriteLine(produto2.ToString());

            // Mostra se são iguais ou não
            Console.WriteLine(produto1.Equals(produto2) ? "Produtos são iguais" : "Produtos não são iguais");
        }
    }
}