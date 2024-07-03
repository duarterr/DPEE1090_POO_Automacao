namespace Course
{
    // Classe para sensores de pressão (herda de Sensor)
    public class SensorPressao : Sensor
    {
        public override double Medir()
        {
            // Simulação de medição de pressão (valor aleatório para exemplo)
            Random rand = new Random();
            return rand.NextDouble() * 100.0; // Pressão entre 0.0 e 100.0 unidades de pressão
        }
    }
}
