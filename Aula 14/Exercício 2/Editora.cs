namespace Course
{
    // Classe Editora que herda de Empresa
    public class Editora : Empresa
    {
        // Construtor da classe Editora que inicializa os atributos de Empresa
        public Editora(string nome, string cnpj) : base(nome, cnpj)
        {
        }
    }
}
