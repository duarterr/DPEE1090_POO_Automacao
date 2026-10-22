namespace Course
{   
    // Classe base abstrata para Sensor
    public abstract class Sensor
    {
        public string Nome { get; private set; }

        // Construtor protegido: chamado pelas subclasses para definir o nome do sensor
        protected Sensor(string nome)
        {
            Nome = nome;
        }

        // Método abstrato para medir dados do sensor
        public abstract double Medir();

        // Método virtual para monitorar o sensor (pode ser sobrecarregado nas subclasses)
        public virtual void Monitorar()
        {
            Console.WriteLine($"Monitorando sensor {Nome}...");
        }
    }
}
