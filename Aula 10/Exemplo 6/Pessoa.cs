namespace Course
{
    // Definição da classe Pessoa
    internal class Pessoa
    {
        // Propriedade pública Nome que armazena o nome da pessoa
        public string Nome { get; set; }

        // Propriedade EndRes que armazena o endereço da pessoa.
        // O modificador 'private set' indica que essa propriedade só pode ser
        // modificada dentro da classe Pessoa, reforçando o conceito de composição.
        public Endereco EndRes { get; private set; }

        // Construtor da classe Pessoa que inicializa as propriedades Nome e EndRes
        public Pessoa(string nome, string rua, string cidade, string estado)
        {
            Nome = nome; // Inicializa a propriedade Nome com o valor fornecido

            // Inicializa a propriedade EndRes com um novo objeto Endereco
            // A classe Pessoa é responsável pela criação e gerenciamento do objeto Endereco
            // Isso caracteriza a composição, pois EndRes é parte integrante de Pessoa
            EndRes = new Endereco(rua, cidade, estado);
        }

        // Sobrescreve o método ToString para retornar uma representação textual do objeto Pessoa
        public override string ToString()
        {
            // Retorna uma string formatada mostrando o nome da pessoa e seu endereço
            return $"Nome: {Nome}, Endereço: {EndRes}";
        }
    }
}
