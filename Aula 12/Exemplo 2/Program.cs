namespace Course
{
    internal class Program
    {
        // Método principal do programa, ponto de entrada da aplicação
        static void Main(string[] args)
        {
            // Instancia um objeto da classe 'Atuador'
            Atuador MyAtuador = new Atuador();
            // Instancia um objeto da classe 'Sensor'
            Sensor MySensor = new Sensor();
            // Instancia um objeto da classe 'Controlador'
            Controlador MyControlador = new Controlador();

            // Demonstração do polimorfismo estático através da chamada do método 'Operar'
            MyAtuador.Operar();       // Chama o método 'Operar' específico da classe 'Atuador'
            MySensor.Operar();        // Chama o método 'Operar' específico da classe 'Sensor'
            MyControlador.Operar();   // Chama o método 'Operar' específico da classe 'Controlador'
        }
    }
}
