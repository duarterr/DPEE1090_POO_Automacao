namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------
            // PARTE 1 - UPCASTING: duas variáveis, um único objeto
            // ------------------------------------------------------------------

            // Um único objeto: a conta empresa do Bruno
            BusinessAccount contaEmpresa =
                new BusinessAccount(1002, "Bruno", 100.0, 500.0);

            // UPCASTING: conta (tipo Account) aponta para o MESMO objeto
            Account conta = contaEmpresa;

            conta.Deposit(50.0);     // OK: Deposit existe em Account
            // conta.Loan(100.0);    // ERRO: Account não tem Loan

            // O depósito aparece em contaEmpresa: é o mesmo objeto
            Console.WriteLine(contaEmpresa.Balance);   // 150

            // ------------------------------------------------------------------
            // PARTE 2 - DOWNCASTING: voltar ao tipo da subclasse
            // ------------------------------------------------------------------

            // DOWNCASTING: enxergar o objeto de novo como BusinessAccount
            BusinessAccount mesmaContaEmpresa = (BusinessAccount)conta;

            // OK: o objeto apontado por conta É uma BusinessAccount
            mesmaContaEmpresa.Loan(100.0);
            Console.WriteLine(contaEmpresa.Balance);   // 250

            // PERIGO: o compilador aceita, mas o objeto é uma SavingsAccount
            Account outraConta =
                new SavingsAccount(1003, "Carla", 100.0, 0.01);
            // BusinessAccount erro = (BusinessAccount)outraConta;
            // Compila, mas gera InvalidCastException ao executar!

            // ------------------------------------------------------------------
            // PARTE 3 - Por que usar upcasting?
            // ------------------------------------------------------------------

            // Upcasting permite guardar contas de tipos diferentes juntas
            Account[] contas =
            {
                new Account(1001, "Ana", 100.0),
                new BusinessAccount(1002, "Bruno", 100.0, 500.0),
                new SavingsAccount(1003, "Carla", 100.0, 0.01)
            };

            foreach (Account contaAtual in contas)
            {
                // Downcasting só depois de testar o tipo real do objeto
                if (contaAtual is BusinessAccount)
                {
                    BusinessAccount contaEmpresaAtual = (BusinessAccount)contaAtual;
                    contaEmpresaAtual.Loan(200.0);
                }
                else if (contaAtual is SavingsAccount)
                {
                    SavingsAccount contaPoupancaAtual = (SavingsAccount)contaAtual;
                    contaPoupancaAtual.UpdateBalance();
                }
                Console.WriteLine($"{contaAtual.Holder}: {contaAtual.Balance:F2}");
            }
            // Saída:  Ana: 100,00  |  Bruno: 300,00  |  Carla: 101,00
        }
    }
}
