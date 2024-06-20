// Define o namespace do projeto
namespace Course
{
    // Definição da classe OrderItem
    internal class OrderItem
    {
        // Propriedade pública Quantity que armazena a quantidade do item
        public int Quantity { get; set; }

        // Propriedade pública Price que armazena o preço unitário do item
        public double Price { get; set; }

        // Propriedade pública Product que armazena o produto associado ao item
        public Product Product { get; set; }

        // Construtor padrão vazio da classe OrderItem
        public OrderItem()
        {
        }

        // Construtor da classe OrderItem que recebe parâmetros para inicializar Quantity, Price e Product
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;  // Inicializa a propriedade Quantity com o valor fornecido
            Price = price;        // Inicializa a propriedade Price com o valor fornecido
            Product = product;    // Inicializa a propriedade Product com o valor fornecido
        }

        // Método SubTotal que calcula e retorna o subtotal do item (Price * Quantity)
        public double SubTotal()
        {
            return Price * Quantity;
        }

        // Sobrescreve o método ToString para retornar uma representação textual do OrderItem
        public override string ToString()
        {
            return $"{Product.Name}, ${Price:F2}, Quantity: {Quantity}, Subtotal: ${SubTotal():F2}";
        }
    }
}
