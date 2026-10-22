namespace Course
{
    // Define uma classe abstrata chamada Device (Dispositivo)
    abstract class Device
    {
        // Método abstrato para ligar o dispositivo (deve ser implementado nas classes derivadas)
        public abstract void TurnOn();

        // Método abstrato para desligar o dispositivo (deve ser implementado nas classes derivadas)
        public abstract void TurnOff();

        // Método concreto (não abstrato) para redefinir o dispositivo
        public void Reset()
        {
            Console.WriteLine("Resetting device..."); // Exibe uma mensagem indicando que o dispositivo está sendo redefinido
        }
    }
}
