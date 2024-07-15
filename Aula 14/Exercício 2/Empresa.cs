namespace Course
{
    // Classe Empresa para representar uma entidade genérica de empresa com nome e CNPJ
    public class Empresa
    {
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }

        // Construtor da classe Empresa
        public Empresa(string nome, string cnpj)
        {
            Nome = nome;
            CNPJ = cnpj;
        }
    }
}
