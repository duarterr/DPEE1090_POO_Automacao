namespace Course
{
    // Definição do namespace Course
    abstract class Vehicle : IVehicle
    {
        // Propriedades protegidas da classe Vehicle
        protected string Model { get; set; }  // Modelo do veículo
        protected Color Color { get; set; }   // Cor do veículo
        protected int Year { get; set; }      // Ano do veículo

        // Construtor da classe Vehicle
        protected Vehicle(string model, Color color, int year)
        {
            Model = model;    // Inicializa o modelo do veículo
            Color = color;    // Inicializa a cor do veículo
            Year = year;      // Inicializa o ano do veículo
        }

        // Método público para mostrar informações do veículo
        public void ShowInfo()
        {
            // Imprime informações formatadas sobre o veículo
            Console.WriteLine($"{Year} {Model}, color {Color}");
        }

        // Métodos abstratos da interface IVehicle
        // Métodos abstratos para iniciar e parar o veículo, a serem implementados pelas classes derivadas
        public abstract void Start();
        public abstract void Stop();
    }
}
