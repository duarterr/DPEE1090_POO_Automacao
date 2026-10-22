namespace Course
{
    // Define uma classe concreta chamada Motor que herda da classe abstrata Actuator
    class Motor : Actuator
    {
        // Implementação do método abstrato PerformAction() da classe Actuator
        public override void PerformAction()
        {
            Console.WriteLine("Motor is performing an action."); // Exibe uma mensagem indicando que o motor está realizando uma ação
        }

        // Implementação do método abstrato TurnOn() da classe Device para ligar o motor
        public override void TurnOn()
        {
            Console.WriteLine("Motor is now on."); // Exibe uma mensagem indicando que o motor foi ligado
        }

        // Implementação do método abstrato TurnOff() da classe Device para desligar o motor
        public override void TurnOff()
        {
            Console.WriteLine("Motor is now off."); // Exibe uma mensagem indicando que o motor foi desligado
        }
    }
}
