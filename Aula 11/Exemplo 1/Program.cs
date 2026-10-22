namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10, "blue");
            Triangle triangle = new Triangle(4, 3, "red");

            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");
            Console.WriteLine($"Color: {rectangle.Color}");
            Console.WriteLine($"Number of sides: {rectangle.NumSides}");
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

            Console.WriteLine();

            Console.WriteLine("Right Triangle:");
            Console.WriteLine($"Base: {triangle.BaseLength}, Height: {triangle.Height}");
            Console.WriteLine($"Color: {triangle.Color}");
            Console.WriteLine($"Number of sides: {triangle.NumSides}");
            Console.WriteLine($"Area: {triangle.GetArea()}");
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");

            Console.WriteLine();

            // Prévia da próxima aula (polimorfismo): uma lista do tipo da classe abstrata
            // pode guardar objetos de qualquer subclasse concreta
            List<Shape> shapes = new List<Shape> { rectangle, triangle };
            foreach (Shape shape in shapes)
            {
                // Describe() é o mesmo método para todos, mas dentro dele cada objeto
                // executa a sua própria implementação de GetArea()
                Console.WriteLine(shape.Describe());
            }
        }
    }
}
