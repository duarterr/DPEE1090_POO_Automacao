namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10, "blue");
            Triangle triangle = new Triangle(4, 3, "red");

            rectangle.Resize(2);

            // Uma interface também é um tipo: a variável 'resizable' enxerga apenas o que o contrato
            // IResizable define (o método Resize), mas o objeto continua sendo um Triangle
            IResizable resizable = triangle;
            resizable.Resize(10);

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
        }
    }
}
