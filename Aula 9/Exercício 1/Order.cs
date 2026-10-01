namespace Course
{
    internal class Order
    {
        // Atributos da classe Order
        public int Id { get; set; } // Identificador único do pedido
        public double Value { get; set; } // Valor do pedido
        public OrderStatus Status { get; set; } // Status atual do pedido

        // Construtor da classe Order
        public Order(int id, double value, OrderStatus status)
        {
            Id = id;
            Value = value;
            Status = status;
        }

        // Método ToString para imprimir os dados do pedido
        public override string ToString()
        {
            return $"Order ID: {Id}, Value: ${Value}, Status: {Status}";
        }
    }
}
