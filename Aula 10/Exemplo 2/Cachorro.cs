namespace Course
{
    // Classe derivada representando um cachorro, herda de Animal.
    internal class Cachorro : Animal
    {
        // Atributo da raça
        public string Raca { get; set; }

        // Construtor sem argumentos
        // Construtores não são herdados: Cachorro precisa definir os seus.
        // Este construtor chama implicitamente o construtor sem argumentos de Animal.
        // Teste: apague o construtor Animal() e veja o erro de compilação aqui.
        public Cachorro() { }

        // Construtores com argumentos
        // Metodo 1 - Não ideal pois repete código da superclasse
        //public Cachorro(string nome, string raca) 
        //{
        //    Nome = nome;
        //    Raca = raca;
        //}

        // Metodo 2 - Chama construtor da superclasse
        // Para isso usamos a palavra base
        public Cachorro(string nome, string raca) : base (nome)
        {
            Raca = raca;
        }
    }
}
