namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 07, 11, 9, 0, 0);
            Console.WriteLine(dt.ElapsedTime());

            DateTime dt2 = new DateTime(2024, 07, 10, 9, 0, 0);
            Console.WriteLine(dt2.ElapsedTime());
        }
    }
}