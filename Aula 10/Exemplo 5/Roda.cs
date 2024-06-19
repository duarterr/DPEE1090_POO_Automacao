namespace Course
{
    // Definição da classe Roda
    internal class Roda
    {
        // Propriedade pública Tamanho que armazena o tamanho da roda em polegadas
        public int Tamanho { get; set; }

        // Construtor da classe Roda que recebe um parâmetro tamanho
        public Roda(int tamanho)
        {
            Tamanho = tamanho; // Inicializa a propriedade Tamanho com o valor recebido no construtor
        }

        // Sobrescreve o método ToString para retornar uma representação em string do objeto Roda
        public override string ToString()
        {
            return $"Roda: Tamanho = {Tamanho} polegadas"; // Retorna uma string formatada mostrando o tamanho da roda em polegadas
        }
    }
}
