namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Criando instâncias de diferentes tipos de conta.
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            SavingsAccount sacc = new SavingsAccount(1003, "Bob", 0.0, 0.01);

            // UPCASTING: Conversão implícita de tipos derivados para o tipo base.

            // Exemplo de upcasting: BusinessAccount é convertido para Account.
            Account acc1 = bacc;
           
            // Outro exemplo de upcasting: Criando uma nova instância de BusinessAccount diretamente como Account.
            Account acc2 = new BusinessAccount(1004, "Bob", 0.0, 200.0);
           
            // A linha abaixo seria inválida porque a variável acc2 é do tipo Account, que não possui o método Loan.
            // acc2.Loan(100.00);

            // DOWNCASTING: Conversão explícita de tipos base para tipos derivados.

            // Exemplo de downcasting: Convertendo Account de volta para BusinessAccount.
            BusinessAccount bacc2 = (BusinessAccount)acc2;

            // Sintaxe alternativa
            BusinessAccount bacc3 = acc2 as BusinessAccount; 

            // Agora podemos chamar o método Loan, pois a variável bacc2 é do tipo BusinessAccount.
            bacc2.Loan(100.0);

            // Tentativa de downcasting de SavingsAccount para BusinessAccount. Compila mas gera exceção em tempo de execução.
            Account acc3 = sacc;

            // A linha abaixo não compila porque Account não é diretamente compatível com BusinessAccount.
            // BusinessAccount bacc4 = (BusinessAccount)acc3;

            // Testando se o downcasting é possível antes de fazer a conversão.
            if (acc3 is BusinessAccount)
            {
                BusinessAccount bacc5 = (BusinessAccount)acc3;
            }
        }
    }
}
