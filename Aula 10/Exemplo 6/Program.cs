namespace Course
{
    // Classe interna Program
    internal class Program
    {
        // Método principal Main, que é o ponto de entrada do programa
        static void Main(string[] args)
        {
            // Criar um objeto Pessoa e seu Endereco automaticamente através de composição
            Pessoa pessoa = new Pessoa("João Silva", "Rua das Flores", "São Paulo", "SP");

            // Exibir as informações da pessoa
            Console.WriteLine(pessoa);
        }
    }
}
