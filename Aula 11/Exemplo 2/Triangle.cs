namespace Course
{
    // Define uma classe interna (internal) chamada Triangle (Triângulo) que herda da classe Shape (Forma)
    internal class Triangle : Shape, IResizable
    {
        // Propriedades para armazenar a base e altura do triângulo
        public double BaseLength { get; private set; }
        public double Height { get; private set; }

        // Construtor que inicializa a base e altura do triângulo e chama o construtor da classe base Shape com 3 lados e a cor
        public Triangle(double baseLength, double height, string color) : base(3, color)
        {
            BaseLength = baseLength;
            Height = height;
        }

        // Implementação do método abstrato GetArea() para calcular a área do triângulo
        public override double GetArea()
        {
            return 0.5 * BaseLength * Height; // Fórmula da área de um triângulo: base * altura / 2
        }

        // Implementação do método abstrato GetPerimeter() para calcular o perímetro do triângulo
        public override double GetPerimeter()
        {
            // Considerando um triângulo retângulo (base e altura são os catetos),
            // a hipotenusa é obtida pelo teorema de Pitágoras
            double hipotenusa = Math.Sqrt(BaseLength * BaseLength + Height * Height);
            return BaseLength + Height + hipotenusa;
        }

        // Implementação do método Resize() da interface IResizable para redimensionar o triângulo
        public void Resize(double scale)
        {
            BaseLength *= scale;
            Height *= scale;
        }
    }
}
