namespace Course
{
    // Definição da classe Pessoa dentro do namespace Course
    public class Pessoa
    {
        // Propriedade Id da pessoa, apenas com getter privado (somente leitura fora da classe)
        public int Id { get; private set; }

        // Propriedade Nome da pessoa, apenas com getter privado (somente leitura fora da classe)
        public string Nome { get; private set; }

        // Construtor da classe Pessoa, inicializa os atributos Id e Nome
        public Pessoa(int id, string nome)
        {
            Id = id;     // Atribui o valor do parâmetro id à propriedade Id
            Nome = nome; // Atribui o valor do parâmetro nome à propriedade Nome
        }
    }
}
