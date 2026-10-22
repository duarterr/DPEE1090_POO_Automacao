namespace Course
{
    internal class Program
    {
        // Método principal do programa, ponto de entrada da aplicação
        static void Main(string[] args)
        {
            // Cria uma lista de objetos do tipo 'Dispositivo'
            List<Dispositivo> Dispositivos = new List<Dispositivo>();

            // Adiciona objetos de diferentes subclasses à lista
            Dispositivos.Add(new Atuador());     // Adiciona um objeto da classe 'Atuador'
            Dispositivos.Add(new Sensor());      // Adiciona um objeto da classe 'Sensor'
            Dispositivos.Add(new Controlador()); // Adiciona um objeto da classe 'Controlador'

            // Utiliza um loop 'foreach' para percorrer a lista de dispositivos
            foreach (var Disp in Dispositivos)
            {
                // Chama o método 'Operar' para cada dispositivo na lista
                // Polimorfismo dinâmico: em tempo de execução, o método 'Operar' específico da subclasse do objeto
                // será chamado, mesmo que a referência seja do tipo 'Dispositivo'
                Disp.Operar();
            }
        }
    }
}
