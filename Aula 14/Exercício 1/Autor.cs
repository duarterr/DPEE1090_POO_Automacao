namespace Course
{
    // Definição da classe Autor dentro do namespace Course, que herda da classe Pessoa
    public class Autor : Pessoa
    {
        // Construtor da classe Autor que chama o construtor da classe base Pessoa
        public Autor(int id, string nome) : base(id, nome)
        {
            // O construtor da classe base (Pessoa) é invocado com os argumentos id e nome
            // Isso inicializa os atributos Id e Nome da classe base Pessoa com os valores fornecidos
        }
    }
}
