namespace Course
{
    internal class Car : Vehicle
    {
        // Construtor da classe Car que chama o construtor da classe base Vehicle
        public Car(string model, Color color, int year) : base(model, color, year)
        {
        }

        // Implementação do método abstrato Start() da classe base Vehicle
        public override void Start()
        {
            // Mensagem exibida quando o carro convencional é iniciado
            Console.WriteLine("Conventional car started.");
        }

        // Implementação do método abstrato Stop() da classe base Vehicle
        public override void Stop()
        {
            // Mensagem exibida quando o carro convencional é parado
            Console.WriteLine("Conventional car stopped.");
        }
    }
}
