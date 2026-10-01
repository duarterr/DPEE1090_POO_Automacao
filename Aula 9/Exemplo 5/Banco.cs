// Definindo o namespace do projeto
namespace Course
{
    // A classe Banco é interna, o que significa que só é acessível dentro do mesmo assembly
    internal class Banco
    {
        // Propriedade pública para armazenar o material do banco
        public string Material { get; set; }

        // Construtor da classe que inicializa a propriedade Material
        public Banco(string material)
        {
            Material = material;
        }

        // Método override do ToString para fornecer uma representação em string do objeto Banco
        public override string ToString()
        {
            // Retorna uma string que descreve o banco com o material
            return $"Banco: Material = {Material}";
        }
    }
}
