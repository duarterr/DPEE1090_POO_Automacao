namespace Course
{
    // Classe pai
    internal class Animal
    {
        public string Nome;
        public int Idade;

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método virtual: pode ser sobrescrito pelas subclasses
        public virtual void FazBarulho()
        {
            Console.WriteLine($"O animal {Nome} faz barulho");
        }
    }

    // Subclasse
    internal class Cachorro : Animal
    {
        public string Raca;

        public Cachorro(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }

        // Sobrescrita: substitui o comportamento herdado
        public override void FazBarulho()
        {
            Console.WriteLine($"O cachorro {Nome} faz auau");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Instâncias
            Animal animal1 = new Animal("Rex", 5);
            Cachorro cachorro1 = new Cachorro("Toby", 10, "pug");

            // Mesmo nome de método, comportamentos diferentes
            animal1.FazBarulho();
            cachorro1.FazBarulho();

            //internal class Gato : Animal { ... FazBarulho() → "faz miau" }
            //Gato gato1 = new Gato("Mingau", 2, "persa");
            //gato1.FazBarulho();
        }
    }
}
