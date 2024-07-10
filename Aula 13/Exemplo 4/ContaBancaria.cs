namespace Course
{
    internal class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ContaBancariaException("Saldo insuficiente para realizar o saque.");
            }

            Saldo -= valor;
        }
    }
}
