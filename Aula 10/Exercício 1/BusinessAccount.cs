namespace Course
{
    // Classe que representa uma conta de negócios, herda da classe Account.
    internal class BusinessAccount : Account
    {
        // Propriedade para o limite de empréstimo da conta de negócios.
        public double LoanLimit { get; private set; }

        // Construtor padrão.
        public BusinessAccount() { }

        // Construtor que inicializa os valores da conta de negócios.
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        // Método para realizar um empréstimo na conta de negócios.
        public void Loan(double amount)
        {
            // Verifica se o valor do empréstimo é menor ou igual ao limite de empréstimo.
            if (amount <= LoanLimit)
            {
                // Adiciona o valor do empréstimo ao saldo da conta.
                Balance += amount;
            }
        }
    }
}
