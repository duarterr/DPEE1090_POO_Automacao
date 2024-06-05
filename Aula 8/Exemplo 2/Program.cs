namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criação de uma instância de Cachorro.
            Cachorro cachorro = new Cachorro("Bob", "SRD");

            // Imprime valores de cachorro
            Console.WriteLine(cachorro.Nome);
            Console.WriteLine(cachorro.Raca);
        }
    }
}
