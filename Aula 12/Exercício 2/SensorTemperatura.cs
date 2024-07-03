namespace Course
{
    // Classe para sensores de temperatura (herda de Sensor)
    public class SensorTemperatura : Sensor
    {
        public override double Medir()
        {
            // Simulação de medição de temperatura (valor aleatório para exemplo)
            Random rand = new Random();
            return rand.NextDouble() * 50.0; // Temperatura entre 0.0 e 50.0 graus Celsius
        }

        public override void Monitorar()
        {
            Console.WriteLine($"*** ALERTA DE TEMPERATURA *** - Medição de sensor {Nome} excedeu o limite!");
        }
    }
}
