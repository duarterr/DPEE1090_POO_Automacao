using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste 1: Criar um produto com todos os atributos
            ProdutoEletronico produto1 = new ProdutoEletronico("Smartphone", "Samsung", 1999.99, 10);
            Console.WriteLine(produto1.ToString());

            // Teste 2: Criar um produto com apenas nome e marca
            ProdutoEletronico produto2 = new ProdutoEletronico("Laptop", "Dell");
            Console.WriteLine(produto2.ToString());

            // Teste 3: Adicionar ao estoque de produto2
            produto2.AdicionarAoEstoque(15);
            produto2.Preco = 3500.00; // Definir o preço para o produto2
            Console.WriteLine(produto2.ToString());

            // Teste 4: Vender unidades de produto1
            produto1.Vender(3);
            Console.WriteLine(produto1.ToString());

            // Teste 5: Tentar vender mais unidades do que o disponível em estoque
            produto1.Vender(20); // Não deve alterar o estoque
            Console.WriteLine(produto1.ToString());

            // Teste 6: Adicionar quantidade negativa ao estoque de produto2 (não deve alterar o estoque)
            produto2.AdicionarAoEstoque(-5);
            Console.WriteLine(produto2.ToString());

            // Teste 7: Definir preço negativo para produto1 (não deve alterar o preço)
            produto1.Preco = -500.00;
            Console.WriteLine(produto1.ToString());

            // Teste 8: Definir estoque negativo para produto1 (não deve alterar o estoque)
            produto1.Estoque = -10;
            Console.WriteLine(produto1.ToString());
        }
    }
}
