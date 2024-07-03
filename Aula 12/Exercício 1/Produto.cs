using System.Globalization;

namespace Course
{
    // Classe base para Produto
    public class Produto
    {
        // Propriedades comuns a todos os produtos
        public string Nome { get; protected set; }
        public double Preco { get; protected set; }

        // Construtor da classe Produto
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Método para calcular o preço final (não inclui taxa de importação nem data de fabricação)
        public virtual string Etiqueta()
        {
            return $"{Nome} - R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
