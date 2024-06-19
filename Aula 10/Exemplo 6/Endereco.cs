namespace Course
{
    // Definição da classe Endereco
    internal class Endereco
    {
        // Propriedades públicas que representam os atributos do endereço
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        // Construtor da classe Endereco que inicializa suas propriedades
        public Endereco(string rua, string cidade, string estado)
        {
            Rua = rua;        // Inicializa a propriedade Rua com o valor fornecido
            Cidade = cidade;  // Inicializa a propriedade Cidade com o valor fornecido
            Estado = estado;  // Inicializa a propriedade Estado com o valor fornecido
        }

        // Sobrescreve o método ToString para retornar uma representação textual do endereço
        public override string ToString()
        {
            // Retorna uma string formatada mostrando a rua, cidade e estado do endereço
            return $"{Rua}, {Cidade}, {Estado}";
        }
    }
}
