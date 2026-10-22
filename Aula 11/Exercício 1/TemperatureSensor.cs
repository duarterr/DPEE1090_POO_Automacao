namespace Course
{
    // Define uma classe concreta chamada TemperatureSensor que herda da classe abstrata Sensor
    class TemperatureSensor : Sensor
    {
        // Implementação do método abstrato ReadData() da classe Sensor para ler dados de temperatura
        public override void ReadData()
        {
            Console.WriteLine("Reading temperature data..."); // Exibe uma mensagem indicando que os dados de temperatura estão sendo lidos
        }

        // Implementação do método abstrato TurnOn() da classe Device para ligar o sensor de temperatura
        public override void TurnOn()
        {
            Console.WriteLine("Temperature sensor is now on."); // Exibe uma mensagem indicando que o sensor de temperatura foi ligado
        }

        // Implementação do método abstrato TurnOff() da classe Device para desligar o sensor de temperatura
        public override void TurnOff()
        {
            Console.WriteLine("Temperature sensor is now off."); // Exibe uma mensagem indicando que o sensor de temperatura foi desligado
        }
    }
}
