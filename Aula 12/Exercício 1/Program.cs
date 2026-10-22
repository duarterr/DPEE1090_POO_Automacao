using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        // Método principal do programa, ponto de entrada da aplicação
        static void Main(string[] args)
        {
            // Lista para armazenar os produtos inseridos pelo usuário
            List<Produto> produtos = new List<Produto>();

            // Solicita ao usuário o número de produtos a serem cadastrados
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para inserir os dados de cada produto
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto #{i}:");

                // Solicita o tipo de produto: comum, usado ou importado
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());

                // Solicita o nome do produto
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                // Solicita o preço do produto
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Condições para criar o objeto Produto, ProdutoUsado ou ProdutoImportado
                if (tipo == 'i')
                {
                    // Se o produto for importado, solicita a taxa de alfândega
                    Console.Write("Taxa de Alfândega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
                else if (tipo == 'u')
                {
                    // Se o produto for usado, solicita a data de fabricação
                    Console.Write("Data de fabricação (DD/MM/AAAA): ");
                    DateTime dataFabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else
                {
                    // Se o produto for comum, adiciona um objeto Produto na lista
                    produtos.Add(new Produto(nome, preco));
                }
            }

            // Espaçamento para separar os dados dos produtos da exibição das etiquetas de preço
            Console.WriteLine();

            // Exibe as etiquetas de preço dos produtos cadastrados
            Console.WriteLine("Etiquetas de Preço:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.Etiqueta());
            }
        }
    }
}
