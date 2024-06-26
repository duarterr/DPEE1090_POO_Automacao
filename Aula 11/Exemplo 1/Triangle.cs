namespace Course
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height) : base(3)
        {
            Base = @base;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public override double GetPerimeter()
        {
            // Para calcular o perímetro, precisaríamos da lógica específica de um triângulo retângulo,
            // porém, como o cálculo do perímetro não é trivial para um triângulo genérico, vamos retornar 0
            return 0;
        }
    }
}
