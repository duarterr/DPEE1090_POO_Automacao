namespace Prova
{
    // Definição da classe Retangulo
    internal class Retangulo
    {
        // Campos privados para armazenar a largura e a altura do retângulo
        private double _largura;
        private double _altura;

        // Propriedade para acessar e modificar a largura com validação
        public double Largura
        {
            get { return _largura; }
            set
            {
                // Valida se o valor está no intervalo permitido (0 <= valor <= 100)
                if (value >= 0 && value <= 100)
                    _largura = value; // Atribui o valor à largura se for válido
            }
        }

        // Propriedade para acessar e modificar a altura com validação
        public double Altura
        {
            get { return _altura; }
            set
            {
                // Valida se o valor está no intervalo permitido (0 <= valor <= 100)
                if (value >= 0 && value <= 100)
                    _altura = value; // Atribui o valor à altura se for válido
            }
        }

        // Construtor da classe Retangulo que inicializa os valores de largura e altura
        public Retangulo(double largura, double altura)
        {
            // Atribui os valores recebidos às propriedades Largura e Altura
            // Isso garante que a validação ocorra ao inicializar o objeto
            Largura = largura;
            Altura = altura;
        }

        // Método que calcula a área do retângulo
        public double Area()
        {
            // Retorna o produto da largura pela altura
            return Largura * Altura;
        }
    }
}
