namespace Course
{
    // Classe para sensores de emergência (herda de Sensor)
    public class SensorEmergencia : Sensor
    {
        public override double Medir()
        {
            // Simulação de medição de emergência (valor fixo para exemplo)
            return 100.0;
        }

        public override void Monitorar()
        {
            Console.WriteLine($"*** ALERTA DE EMERGÊNCIA *** - Medição de sensor {Nome} excedeu o limite!");
        }
    }
}
