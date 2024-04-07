namespace Course
{
    internal class Pessoa
    {
        // Atributos
        public string Nome;
        public int Idade;

        // Construtor da classe - Com parâmetros
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Sobreescrita do método Equals para comparação de dois objetos Pessoa
        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa &&
                   Nome == pessoa.Nome &&
                   Idade == pessoa.Idade;
        }
    }
}
