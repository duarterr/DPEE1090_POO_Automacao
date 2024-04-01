namespace Course
{
    internal class Pessoa
    {
        // Atributos da pessoa
        public string Nome;
        public int Idade;
        public double Altura;

        // Construtor 1
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Construtor 2
        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

    }
}
