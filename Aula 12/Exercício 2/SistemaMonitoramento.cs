namespace Course
{
    // Classe para o sistema de monitoramento
    public class SistemaMonitoramento
    {
        private List<Sensor> Sensores;

        public SistemaMonitoramento()
        {
            // Adicione diferentes Sensores ao sistema de monitoramento
            Sensores = new List<Sensor>();
            Sensores.Add(new SensorTemperatura() { Nome = "Sensor de Temperatura 1" });
            Sensores.Add(new SensorPressao() { Nome = "Sensor de Pressão 1" });
            Sensores.Add(new SensorEmergencia() { Nome = "Sensor de Emergência 1" });
        }

        public void IniciarMonitoramento()
        {
            foreach (var Sensor in Sensores)
            {
                // Polimorfismo: chama o método específico de cada sensor
                Console.WriteLine($"Medição do sensor {Sensor.Nome}: {Sensor.Medir()}");

                // Polimorfismo: pode chamar diferentes implementações de Monitorar
                Sensor.Monitorar(); 

                Console.WriteLine();
            }
        }
    }

}
