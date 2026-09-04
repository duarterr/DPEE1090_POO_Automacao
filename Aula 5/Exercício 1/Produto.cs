using System.Globalization;
using System.Text;

namespace Course
{
    internal class Produto
    {
        // Atributos da classe
        public string Nome;
        public int Codigo;
        public double Valor;
        public uint Quantidade;

        // Construtor da classe - Sem atriburos
        public Produto ()
        {

        }

        // Construtor da classe - Com atributos
        public Produto(string nome, int codigo, double valor, uint quantidade)
        {
            Nome = nome;
            Codigo = codigo;
            Valor = valor;
            Quantidade = quantidade;
        }

        // Método para calcular o valor total em estoque
        public double ValorEmEstoque ()
        {
            return Valor * Quantidade;
        }

        // Método para imprimir produto na forma de string
        /*public override string ToString()
        {
            // Cria uma string concatenando todos os dados necessários
            string myString = "Nome: " + Nome + 
                ", Cod: " + Codigo + 
                ", Valor: " + Valor.ToString("F2", CultureInfo.InvariantCulture) +
                ", Qtd: " + Quantidade + 
                ", Total em estoque: " + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
            
            // Retorna string criada
            return myString;
        }*/

        // Versão alternativa da função acima usando o stringBuilder do .NET (não é escopo da disciplina)
        // https://learn.microsoft.com/pt-br/dotnet/standard/base-types/stringbuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.Append(", Cod: "); 
            sb.Append(Codigo);
            sb.Append(", Valor: ");
            sb.Append(Valor.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Qtd: "); 
            sb.Append(Quantidade); 
            sb.Append(", Total em estoque: "); 
            sb.Append(ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();
        }

        // Método para comparação de dois produtos
        public override bool Equals(object? obj)
        {
            // Nenhum objeto foi passado como parametro
            if (obj == null)
                return false;

            // Objeto passado como parametro é um produto - Salva em prod2
            if (obj is Produto prod2)
            {
                // Verdadeiro se nome e código são iguais
                // "this" não é necessário nessa declaração. Apenas para enfatizar que estamos comparando
                // atributos do objeto atual com os de prod2, recebido como argumento do método
                return this.Nome == prod2.Nome && this.Codigo == prod2.Codigo;
            }

            // Objeto passado não é um produto
            else
                return false;
        }
    }
}
