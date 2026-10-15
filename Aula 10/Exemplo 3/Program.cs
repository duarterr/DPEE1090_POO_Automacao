namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // UPCASTING: conversão implícita da subclasse para a superclasse.
            // Criando instâncias de BusinessAccount e SavingsAccount diretamente como Account.
            Account acc = new BusinessAccount(1004, "Bob", 0.0, 200.0);
            Account acc2 = new SavingsAccount(1005, "Ana", 100.0, 0.01);

            // A linha abaixo não compila: a variável acc é do tipo Account, que não possui o método Loan.
            // acc.Loan(100.0);

            // DOWNCASTING: conversão explícita da superclasse para a subclasse.
            // Convertendo Account de volta para BusinessAccount.
            BusinessAccount bacc = (BusinessAccount)acc;

            // Agora podemos chamar o método Loan, pois a variável bacc é do tipo BusinessAccount.
            bacc.Loan(100.0);
            Console.WriteLine($"Saldo de {bacc.Holder}: {bacc.Balance}");

            // PERIGO: a linha abaixo COMPILA, mas gera um erro (InvalidCastException)
            // ao executar, pois acc2 aponta para um objeto do tipo SavingsAccount.
            // BusinessAccount bacc2 = (BusinessAccount)acc2;

            // Teste para verificar o tipo antes de fazer a conversão.
            if (acc2 is BusinessAccount)
            {
                BusinessAccount bacc3 = (BusinessAccount)acc2;
                bacc3.Loan(200.0);
                Console.WriteLine("Empréstimo realizado!");
            }
            else if (acc2 is SavingsAccount)
            {
                SavingsAccount sacc = (SavingsAccount)acc2;
                sacc.UpdateBalance();
                Console.WriteLine($"Saldo de {sacc.Holder} atualizado: {sacc.Balance}");
            }
        }
    }
}
