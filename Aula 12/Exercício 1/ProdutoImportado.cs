using System.Globalization;

namespace Course
{
    // Classe para produtos importados (herda de Produto)
    public class ProdutoImportado : Produto
    {
        // Propriedade específica para produtos importados
        public double TaxaAlfandega { get; protected set; }

        // Construtor da classe ProdutoImportado
        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        // Método para calcular o preço final (inclui taxa de importação)
        public override string Etiqueta()
        {
            double precoFinal = Preco + TaxaAlfandega;
            return $"{Nome} - R$ {precoFinal.ToString("F2", CultureInfo.InvariantCulture)} (Taxa de Alfândega: R$ {TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
