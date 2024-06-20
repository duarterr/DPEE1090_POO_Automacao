// Define o namespace do projeto
namespace Course
{
    // Enumeração OrderStatus que define os possíveis estados de uma ordem
    enum OrderStatus : int
    {
        PendingPayment = 0, // Estado de ordem pendente de pagamento
        Processing = 1,     // Estado de ordem em processamento
        Shipped = 2,        // Estado de ordem enviada
        Delivered = 3       // Estado de ordem entregue
    }
}