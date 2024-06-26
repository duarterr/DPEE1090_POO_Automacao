namespace Course
{
    // Define uma classe interna (internal) chamada Triangle (Triângulo) que herda da classe Shape (Forma)
    internal class Triangle : Shape, IResizable
    {
        // Propriedades para armazenar a base e altura do triângulo
        public double Base { get; set; }
        public double Height { get; set; }

        // Construtor que inicializa a base e altura do triângulo e chama o construtor da classe base Shape com 3 lados e a cor
		// Em C#, o símbolo @ antes de um identificador permite que você use palavras reservadas do C# como nomes de identificadores
        public Triangle(double @base, double height, string color) : base(3, color)
        {
            Base = @base; 		// Aqui, @base se refere ao parâmetro da função, não à palavra-chave 'base' do C#
            Height = height;
        }

        // Implementação do método abstrato GetArea() para calcular a área do triângulo
        public override double GetArea()
        {
            return 0.5 * Base * Height; // Fórmula da área de um triângulo: base * altura / 2
        }

        // Implementação do método abstrato GetPerimeter() para calcular o perímetro do triângulo
        public override double GetPerimeter()
        {
            // Como o cálculo do perímetro de um triângulo genérico não é trivial e depende do tipo de triângulo,
            // vamos retornar 0 neste caso. Para um triângulo específico, como um triângulo retângulo, 
            // precisaríamos implementar a lógica apropriada aqui.
            return 0;
        }

        // Implementação do método Resize() da interface IResizable para redimensionar o triângulo
        public void Resize(double scale)
        {
            Base *= scale;
            Height *= scale;
        }
    }
}
