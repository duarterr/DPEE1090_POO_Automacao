// Necessário pois usaremos o StringBuilder da classe System.Text
using System.Text;

// Define o namespace do projeto
namespace Course
{
    // Definição da classe Order
    internal class Order
    {
        // Propriedade pública Moment que armazena o momento da ordem
        public DateTime Moment { get; set; }

        // Propriedade pública Status que armazena o status da ordem
        public OrderStatus Status { get; set; }

        // Propriedade pública Client que armazena o cliente associado à ordem
        public Client Client { get; set; }

        // Lista de OrderItems que armazena os itens da ordem
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // Construtor padrão vazio da classe Order
        public Order()
        {
        }

        // Construtor da classe Order que recebe parâmetros para inicializar Moment, Status e Client
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;    // Inicializa a propriedade Moment com o valor fornecido
            Status = status;    // Inicializa a propriedade Status com o valor fornecido
            Client = client;    // Inicializa a propriedade Client com o valor fornecido
        }

        // Método para adicionar um item à lista de Items
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        // Método para remover um item da lista de Items
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        // Método Total que calcula e retorna o valor total da ordem somando os subtotais dos itens
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
                sum += item.SubTotal();

            return sum;
        }

        // Sobrescreve o método ToString para retornar uma representação textual da Order
        public override string ToString()
        {
            // Cria um StringBuilder para construir a representação textual da ordem
            StringBuilder sb = new StringBuilder();

            // Adiciona a string formatada "Order moment: " seguida da data e hora formatada de Moment ao StringBuilder
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");

            // Adiciona a string formatada "Order status: " seguida do Status da ordem ao StringBuilder
            sb.AppendLine($"Order status: {Status}");

            // Adiciona a string formatada "Client: " seguida do nome do Cliente ao StringBuilder
            sb.AppendLine($"Client: {Client}");

            // Adiciona a string "Order items:" ao StringBuilder
            sb.AppendLine("Order items:");

            // Itera sobre cada OrderItem na lista de Items e adiciona a representação textual de cada um ao StringBuilder
            foreach (OrderItem item in Items)
                sb.AppendLine(item.ToString());

            // Adiciona a string formatada "Total price: $" seguida do valor total da ordem ao StringBuilder
            sb.AppendLine($"Total price: ${Total():F2}");

            // Retorna a representação textual completa da ordem como uma string
            return sb.ToString();
        }
    }
}
