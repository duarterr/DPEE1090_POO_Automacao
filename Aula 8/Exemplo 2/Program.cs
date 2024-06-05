namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criação de uma instância de Cachorro.
            Cachorro cachorro = new Cachorro();

            // Atribuição de um nome ao cachorro.
            cachorro.Nome = "Rex";

            // Chamada ao método herdado da classe base (Animal).
            cachorro.Comer();

            // Chamada ao método específico da classe Cachorro.
            cachorro.Latir();

            // Criação de uma instância de Gato.
            Gato gato = new Gato();

            // Atribuição de um nome ao gato.
            gato.Nome = "Mimi";

            // Chamada ao método herdado da classe base (Animal).
            gato.Comer();

            // Chamada ao método específico da classe Gato.
            gato.Miar();
        }
    }
}
