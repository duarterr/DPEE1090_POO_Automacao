using System.Globalization;

namespace Course
{
    // Classe para produtos usados (herda de Produto)
    public class ProdutoUsado : Produto
    {
        // Propriedade específica para produtos usados
        public DateTime DataFab { get; protected set; }

        // Construtor da classe ProdutoUsado
        public ProdutoUsado(string nome, double preco, DateTime dataFab)
            : base(nome, preco)
        {
            DataFab = dataFab;
        }

        // Método para calcular o preço final (inclui data de fabricação)
        public override string Etiqueta()
        {
            return $"{Nome} (usado) - R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} (Fabricação: {DataFab.ToString("dd/MM/yyyy")})";
        }
    }
}
