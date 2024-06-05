namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criando uma instância de BusinessAccount com valores iniciais.
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            // Exibindo o saldo inicial da conta.
            Console.WriteLine(account.Balance); // Output: 100.0

            // Realizando um empréstimo na conta.
            account.Loan(100);

            // Exibindo o saldo atualizado após o empréstimo.
            Console.WriteLine(account.Balance); // Output: 200.0
        }
    }
}
