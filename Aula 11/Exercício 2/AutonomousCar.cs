namespace Course
{
    internal class AutonomousCar : Vehicle, INavigation
    {
        // Construtor da classe AutonomousCar que chama o construtor da classe base Vehicle
        public AutonomousCar(string model, Color color, int year) : base(model, color, year)
        {
        }

        // Implementação do método abstrato Start() da classe base Vehicle
        public override void Start()
        {
            // Mensagem exibida quando o carro autônomo é iniciado
            Console.WriteLine("Autonomous car started.");
        }

        // Implementação do método abstrato Stop() da classe base Vehicle
        public override void Stop()
        {
            // Mensagem exibida quando o carro autônomo é parado
            Console.WriteLine("Autonomous car stopped.");
        }

        // Implementação do método DefineRoute() da interface INavigation
        public void DefineRoute()
        {
            // Mensagem exibida quando o carro autônomo está definindo a rota
            Console.WriteLine("Autonomous car is defining route.");
        }

        // Implementação do método Navigate() da interface INavigation
        public void Navigate()
        {
            // Mensagem exibida quando o carro autônomo está navegando
            Console.WriteLine("Autonomous car is navigating.");
        }
    }
}