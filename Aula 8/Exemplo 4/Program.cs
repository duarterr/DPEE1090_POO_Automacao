namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criando instâncias de diferentes tipos de conta.
            Account acc = new Account(1001, "Alex", 100.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 100.0, 500.0);
            SavingsAccount sacc = new SavingsAccount(1003, "Bob", 100.0, 0.01);

            // Sacando valores de cada conta
            acc.Withdraw(5.00);
            bacc.Withdraw(5.00);
            sacc.Withdraw(5.00);

            // Imprimindo o saldo restante
            Console.WriteLine(acc.Balance);
            Console.WriteLine(bacc.Balance);
            Console.WriteLine(sacc.Balance);
        }
    }
}
