namespace Course
{
    // Classe derivada representando um gato, herda de Animal.
    internal class Gato : Animal
    {
        // Método específico do gato que simula o miado.
        public void Miar()
        {
            Console.WriteLine($"{Nome} está miando.");
        }
    }
}
