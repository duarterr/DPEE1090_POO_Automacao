namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine(n1/n2);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine("Tentativa de divisão por zero");
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Formato invalido");
            }
        }
    }
}