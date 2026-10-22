namespace Course
{
    // Classe para o sistema de monitoramento
    public class SistemaMonitoramento
    {
        // Lista de sensores do sistema (campo privado, convenção _camelCase)
        private readonly List<Sensor> _sensores;

        public SistemaMonitoramento()
        {
            // Adiciona diferentes sensores ao sistema de monitoramento
            _sensores = new List<Sensor>();
            _sensores.Add(new SensorTemperatura("Sensor de Temperatura 1"));
            _sensores.Add(new SensorPressao("Sensor de Pressão 1"));
            _sensores.Add(new SensorEmergencia("Sensor de Emergência 1"));
        }

        public void IniciarMonitoramento()
        {
            foreach (var sensor in _sensores)
            {
                // Polimorfismo: chama o método específico de cada sensor
                Console.WriteLine($"Medição do sensor {sensor.Nome}: {sensor.Medir()}");

                // Polimorfismo: pode chamar diferentes implementações de Monitorar
                sensor.Monitorar(); 

                Console.WriteLine();
            }
        }
    }

}
