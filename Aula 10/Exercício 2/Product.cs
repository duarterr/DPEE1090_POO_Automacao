namespace Course
{
    // Definição da classe Product
    internal class Product
    {
        // Propriedade pública Name que armazena o nome do produto
        public string Name { get; private set; }

        // Propriedade pública Price que armazena o preço do produto
        public double Price { get; private set; }

        // Construtor padrão vazio da classe Product
        public Product()
        {
        }

        // Construtor da classe Product que recebe parâmetros para inicializar Name e Price
        public Product(string name, double price)
        {
            Name = name;    // Inicializa a propriedade Name com o valor fornecido
            Price = price;  // Inicializa a propriedade Price com o valor fornecido
        }
    }
}
