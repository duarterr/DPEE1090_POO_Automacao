namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciando dispositivos
            TemperatureSensor tempSensor = new TemperatureSensor();
            Motor motor = new Motor();

            // Usando TemperatureSensor
            tempSensor.TurnOn();
            tempSensor.ReadData();
            tempSensor.Calibrate();
            tempSensor.Reset();
            tempSensor.TurnOff();

            // Usando Motor
            motor.TurnOn();
            motor.PerformAction();
            motor.Reset();
            motor.TurnOff();
        }
    }
}
