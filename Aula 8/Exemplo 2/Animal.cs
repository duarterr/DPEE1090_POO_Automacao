namespace Course
{
    // Classe base representando um animal genérico.
    internal class Animal
    {
        // Propriedade para o nome do animal.
        public string Nome { get; set; }

        // Construtor sem argumentos
        public Animal() { }

        // Construtor com argumento
        public Animal(string nome) 
        {  
            Nome = nome; 
        }
    }
}
