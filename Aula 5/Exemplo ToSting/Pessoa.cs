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
        
        // Sobreescrita do método ToString para formatar string de saída
        public override string? ToString()
        {
            return Nome + ", " + Idade;
        }
    }
}
