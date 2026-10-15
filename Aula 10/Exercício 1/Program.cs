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

            // Testando os métodos herdados da classe Account.
            account.Deposit(50.0);
            Console.WriteLine(account.Balance); // Output: 250.0

            account.Withdraw(30.0);
            Console.WriteLine(account.Balance); // Output: 220.0

            // Empréstimo acima do limite: não é realizado.
            account.Loan(1000.0);
            Console.WriteLine(account.Balance); // Output: 220.0

            // A linha abaixo não compila, pois o set de Balance é protected:
            // o saldo só pode ser alterado pelos métodos das classes.
            // account.Balance = 1000000.0;
        }
    }
}
