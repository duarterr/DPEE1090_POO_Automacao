namespace Course
{
    // Classe derivada representando um cachorro, herda de Animal.
    internal class Cachorro : Animal
    {
        // Atributo da raça
        public string Raca { get; set; }

        // Construtor sem argumentos
        public Cachorro() { }

        // Construtores com argumentos
        // Metodo 1 - Não ideal pois repete código da superclasse
        //public Cachorro(string nome, string raca) 
        //{
        //    Nome = nome;
        //    Raca = raca;
        //}

        // Metodo 2 - Chama construtor da superclasse
        // Para isso usamos a palabra base
        public Cachorro(string nome, string raca) : base (nome)
        {
            Raca = raca;
        }
    }
}
