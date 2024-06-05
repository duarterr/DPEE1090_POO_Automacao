namespace Course
{
    // Classe derivada representando um cachorro, herda de Animal.
    internal class Cachorro : Animal
    {
        // Método específico do cachorro que simula o latido.
        public void Latir()
        {
            Console.WriteLine($"{Nome} está latindo.");
        }
    }
}
