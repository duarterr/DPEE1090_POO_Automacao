namespace Course
{
    // Classe
    internal class Animal
    {
        // Atributo público
        public string Nome;

        // Atributo privado: inacessível de fora da classe
        private int Idade;

        // Construtor
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método público
        public void FazBarulho()
        {
            Console.WriteLine($"O animal {Nome} faz barulho");
        }

        // Getter: acesso controlado ao atributo privado
        public int GetIdade()
        {
            return Idade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto
            Animal animal1 = new Animal("Toby", 10);

            Console.WriteLine(animal1.Nome);

            // Erro de compilação: 'Animal.Idade' é inacessível devido ao seu nível de proteção
            //Console.WriteLine(animal1.Idade);

            //Console.WriteLine(animal1.GetIdade());
        }
    }
}
