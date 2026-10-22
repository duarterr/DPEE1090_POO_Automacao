namespace Course
{
    // Classe base abstrata Vehicle, que implementa a interface IVehicle
    abstract class Vehicle : IVehicle
    {
        // Propriedades protegidas e somente leitura (atribuídas apenas no construtor)
        protected string Model { get; }  // Modelo do veículo
        protected Color Color { get; }   // Cor do veículo
        protected int Year { get; }      // Ano do veículo

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
