namespace Course
{
    // Classe derivada representando um cachorro, herda de Animal.
    internal class Cachorro : Animal
    {
        // Método específico do cachorro que simula o latido.
        public void Latir()
        {
            Console.WriteLine($"O cachorro {Nome} está latindo.");
        }

        // Método que simula o animal comendo. Sobreescreve o método da superclasse
        public new void Comer()
        {
            Console.WriteLine($"O cachorro {Nome} está comendo.");
        }
    }
}
