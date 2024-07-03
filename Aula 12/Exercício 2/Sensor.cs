namespace Course
{   
    // Classe base abstrata para Sensor
    public abstract class Sensor
    {
        public string Nome { get; set; }

        // Método abstrato para medir dados do sensor
        public abstract double Medir();

        // Método virtual para monitorar o sensor (pode ser sobrecarregado nas subclasses)
        public virtual void Monitorar()
        {
            Console.WriteLine($"Monitorando sensor {Nome}...");
        }
    }
}
