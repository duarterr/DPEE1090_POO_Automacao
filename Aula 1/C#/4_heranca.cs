namespace Course
{
    // Classe pai
    internal class Animal
    {
        public string Nome;
        public int Idade;

        // Construtor
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    // Subclasse: herda de Animal
    internal class Cachorro : Animal
    {
        public string Raca;

        // Construtor: chama o construtor da classe pai com base()
        public Cachorro(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }

        public void Apresentacao()
        {
            Console.WriteLine($"Olá, eu sou o(a) {Nome}, tenho {Idade} anos e sou da raça {Raca}.");
        }
    }

    // Subclasse: herda de Animal
    internal class Elefante : Animal
    {
        public double Peso;

        public Elefante(string nome, int idade, double peso) : base(nome, idade)
        {
            Peso = peso;
        }

        public void Apresentacao()
        {
            Console.WriteLine($"Olá, eu sou o(a) {Nome}, tenho {Idade} anos e peso {Peso} kg.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Instância
            Cachorro cachorro1 = new Cachorro("Toby", 10, "pug");

            cachorro1.Apresentacao();

            //Elefante elefante1 = new Elefante("Dumbo", 5, 1500);
            //elefante1.Apresentacao();
        }
    }
}
