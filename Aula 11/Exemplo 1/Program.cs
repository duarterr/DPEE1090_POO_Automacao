namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Triangle triangle = new Triangle(4, 3);

            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}");
            Console.WriteLine($"Number of sides: {rectangle.GetNumSides()}");
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

            Console.WriteLine();

            Console.WriteLine("Right Triangle:");
            Console.WriteLine($"Base: {triangle.Base}, Height: {triangle.Height}");
            Console.WriteLine($"Number of sides: {triangle.GetNumSides()}");
            Console.WriteLine($"Area: {triangle.GetArea()}");
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        }
    }
}
