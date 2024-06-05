using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criando um pedido de exemplo
            Order order1 = new Order(1001, 499.99, OrderStatus.PendingPayment);

            // Imprimindo os dados do pedido
            Console.WriteLine(order1);
        }
    }
}
