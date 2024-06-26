namespace Course
{

    // Define uma classe interna (internal) chamada Rectangle (Retângulo) que herda da classe Shape (Forma)
    internal class Rectangle : Shape, IResizable
    {
        // Propriedades para armazenar largura e altura do retângulo
        public double Width { get; set; }
        public double Height { get; set; }

        // Construtor que inicializa a largura e altura do retângulo e chama o construtor da classe base Shape com 4 lados e a cor
        public Rectangle(double width, double height, string color) : base(4, color)
        {
            Width = width;
            Height = height;
        }

        // Implementação do método abstrato GetArea() para calcular a área do retângulo
        public override double GetArea()
        {
            return Width * Height;
        }

        // Implementação do método abstrato GetPerimeter() para calcular o perímetro do retângulo
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        // Implementação do método Resize() da interface IResizable para redimensionar o retângulo
        public void Resize(double scale)
        {
            Width *= scale;
            Height *= scale;
        }
    }
}
