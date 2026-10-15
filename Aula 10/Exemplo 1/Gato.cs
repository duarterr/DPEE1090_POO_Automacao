namespace Course
{
    // Classe derivada representando um gato, herda de Animal.
    internal class Gato : Animal
    {
        // Método específico do gato que simula o miado.
        public void Miar()
        {
            Console.WriteLine($"O gato {Nome} está miando.");
        }
    }
}
