namespace Course
{
    // Classe que representa uma conta de poupança, herda da classe Account.
    internal class SavingsAccount : Account
    {
        // Propriedade para a taxa de juros da conta de poupança.
        public double InterestRate { get; set; }

        // Construtor padrão.
        public SavingsAccount()
        {
        }

        // Construtor que inicializa os valores da conta de poupança.
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        // Método para atualizar o saldo da conta de poupança com base na taxa de juros.
        public void UpdateBalance()
        {
            // Calcula o novo saldo com base na taxa de juros e adiciona ao saldo atual.
            Balance += Balance * InterestRate;
        }
    }
}
