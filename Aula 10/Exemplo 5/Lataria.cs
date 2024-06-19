// Definindo o namespace do projeto
namespace Course
{
    // A classe Lataria é interna, o que significa que só é acessível dentro do mesmo assembly
    internal class Lataria
    {
        // Propriedade pública para armazenar a cor da lataria
        public string Cor { get; set; }

        // Construtor da classe que inicializa a propriedade Cor
        public Lataria(string cor)
        {
            Cor = cor;
        }

        // Método override do ToString para fornecer uma representação em string do objeto Lataria
        public override string ToString()
        {
            // Retorna uma string que descreve a lataria com a cor
            return $"Lataria: Cor = {Cor}";
        }
    }
}
