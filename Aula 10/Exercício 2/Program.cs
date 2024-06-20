using System;
using System.Globalization;

namespace Course
{
    // Classe interna Program que contém o método principal Main, ponto de entrada do programa
    internal class Program
    {
        // Método principal Main, que é o ponto de entrada do programa
        static void Main(string[] args)
        {
            // Solicita e lê os dados do cliente
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // Cria um espaço em branco para melhorar a visualização
            Console.WriteLine();

            // Solicita e lê os dados da ordem
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // Cria um novo objeto Client com os dados fornecidos
            Client client = new Client(clientName, email, birthDate);

            // Cria um novo objeto Order com a data e hora atual, o status e o cliente fornecidos
            Order order = new Order(DateTime.Now, status, client);

            // Solicita o número de itens para a ordem e lê o valor fornecido
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            // Loop para solicitar e adicionar os itens da ordem
            for (int i = 1; i <= n; i++)
            {
                // Cria um espaço em branco para melhorar a visualização
                Console.WriteLine();

                // Solicita e lê os dados do item da ordem
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Cria um novo objeto Product com o nome e preço fornecidos
                Product product = new Product(productName, price);

                // Solicita e lê a quantidade do produto
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                // Cria um novo objeto OrderItem com a quantidade, preço e produto fornecidos
                OrderItem orderItem = new OrderItem(quantity, price, product);

                // Adiciona o item criado à ordem
                order.AddItem(orderItem);
            }

            // Cria um espaço em branco para melhorar a visualização
            Console.WriteLine();

            // Exibe um resumo da ordem, chamando implicitamente o método ToString() sobrescrito em Order
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
