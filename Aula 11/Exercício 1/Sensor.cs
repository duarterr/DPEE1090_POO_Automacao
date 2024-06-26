namespace Course
{
    // Define uma classe abstrata chamada Sensor que herda da classe Device
    abstract class Sensor : Device
    {
        // Método abstrato para ler dados do sensor (deve ser implementado nas classes derivadas)
        public abstract void ReadData();

        // Método concreto (não abstrato) para calibrar o sensor
        public void Calibrate()
        {
            Console.WriteLine("Calibrating sensor..."); // Exibe uma mensagem indicando que o sensor está sendo calibrado
        }
    }
}
