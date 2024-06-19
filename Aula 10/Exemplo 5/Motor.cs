namespace Course
{
    // Definição da classe Motor
    internal class Motor
    {
        // Propriedade pública Potencia que armazena a potência do motor
        public int Potencia { get; set; }

        // Construtor da classe Motor que recebe um parâmetro potencia
        public Motor(int potencia)
        {
            Potencia = potencia; // Inicializa a propriedade Potencia com o valor recebido no construtor
        }

        // Sobrescreve o método ToString para retornar uma representação em string do objeto Motor
        public override string ToString()
        {
            return $"Motor: Potência = {Potencia} HP"; // Retorna uma string formatada mostrando a potência do motor em HP
        }
    }
}
