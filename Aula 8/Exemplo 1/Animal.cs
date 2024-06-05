namespace Course
{
    // Classe base representando um animal genérico.
    internal class Animal
    {
        // Propriedade para o nome do animal.
        public string Nome { get; set; }

        // Método que simula o animal comendo.
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}
