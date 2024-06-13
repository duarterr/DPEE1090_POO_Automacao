namespace Prova
{
    // Classe para representar um produto eletrônico
    internal class ProdutoEletronico
    {
        // Propriedades para armazenar os atributos do produto
        public string Nome { get; private set; } // Boa pratica definir set como privado mas não obrigatório
        public string Marca { get; private set; } // Boa pratica definir set como privado mas não obrigatório
        private double _preco = 0;
        private int _estoque = 0;

        // Propriedade do preço - Funciona como getter e setter
        public double Preco
        {
            get { return _preco; }
            set
            {
                // Verifica se o valor é maior ou igual a zero antes de atribuir
                if (value >= 0)
                {
                    _preco = value;
                }
            }
        }

        // Propriedade do estoque - Funciona como getter e setter
        public int Estoque
        {
            get { return _estoque; }
            set
            {
                // Verifica se o valor é maior ou igual a zero antes de atribuir
                if (value >= 0)
                {
                    _estoque = value;
                }
            }
        }

        // Construtor para inicializar apenas o nome e a marca do produto
        public ProdutoEletronico(string nome, string marca)
        {
            Nome = nome;
            Marca = marca;
        }


        // Construtor para inicializar todos os atributos do produto
        public ProdutoEletronico(string nome, string marca, double _preco, int _estoque) : this(nome, marca)
        {
            Preco = _preco; // Atribui usando a propriedade para validação
            Estoque = _estoque; // Atribui usando a propriedade para validação
        }

        // Método para adicionar uma quantidade ao _estoque
        public void AdicionarAoEstoque(int quantidade)
        {
            // Validação é feita na propriedade
            Estoque += quantidade;
        }

        // Método para vender uma quantidade específica do produto, atualizando o _estoque
        public void Vender(int quantidade)
        {
            // Verifica se a quantidade é maior ou igual a zero e se há _estoque suficiente antes de vender
            if (quantidade >= 0 && quantidade <= Estoque)
            {
                Estoque -= quantidade;
            }
        }

        // Método para retornar o valor total em _estoque do produto
        public double ValorEmEstoque()
        {
            return Preco * Estoque;
        }

        // Método para retornar o produto em formato de string
        public override string ToString()
        {
            return $"{Nome} ({Marca}) - ${Preco:F2} cada, {Estoque} unidades em estoque - ${ValorEmEstoque():F2} em estoque";
        }
    }
}
