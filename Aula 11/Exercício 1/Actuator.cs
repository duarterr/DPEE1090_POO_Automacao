namespace Course
{
    // Define uma classe abstrata chamada Actuator que herda da classe Device
    abstract class Actuator : Device
    {
        // Método abstrato para realizar uma ação específica (deve ser implementado nas classes derivadas)
        public abstract void PerformAction();
    }
}
