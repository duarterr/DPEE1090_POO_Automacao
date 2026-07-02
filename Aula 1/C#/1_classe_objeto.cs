namespace Course
{
    // Classe
    internal class Animal
    {
        // Atributos
        public string Nome;
        public int Idade;

        // Construtor
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método
        public void FazBarulho()
        {
            Console.WriteLine($"O animal {Nome} faz barulho");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetos
            Animal animal1 = new Animal("Toby", 10);
            Animal animal2 = new Animal("Rex", 5);

            // Cada objeto carrega seus próprios dados
            Console.WriteLine($"{animal1.Nome}, {animal1.Idade}");
            Console.WriteLine($"{animal2.Nome}, {animal2.Idade}");

            // NOTA: Diferente do JavaScript, imprimir o objeto diretamente
            // exibe apenas o nome do tipo (Course.Animal), e não os atributos
            //Console.WriteLine(animal1);

            //animal1.Idade = 35;
            //Console.WriteLine($"{animal1.Nome}, {animal1.Idade}");
            //Console.WriteLine($"{animal2.Nome}, {animal2.Idade}");

            //animal1.FazBarulho();
        }
    }
}
