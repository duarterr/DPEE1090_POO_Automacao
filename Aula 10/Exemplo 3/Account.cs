namespace Course
{
    // Classe que representa uma conta bancária.
    internal class Account
    {
        // Propriedade para o número da conta.
        public int Number { get; private set; }
        // Propriedade para o titular da conta.
        public string Holder { get; private set; }
        // Propriedade para o saldo da conta.
        public double Balance { get; protected set; }

        // Construtor padrão.
        public Account() { }

        // Construtor que inicializa os valores da conta.
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Método para sacar um valor da conta.
        public void Withdraw(double amount)
        {
			// Realiza o saque subtraindo o valor do saldo.
			Balance -= amount;
        }

        // Método para depositar um valor na conta.
        public void Deposit(double amount)
        {
            // Adiciona o valor ao saldo da conta.
            Balance += amount;
        }
    }
}
