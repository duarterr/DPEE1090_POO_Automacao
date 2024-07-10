using System.Diagnostics;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(1000);
            Console.WriteLine($"Saldo inicial: {conta.Saldo:F2}");

            try
            {
                conta.Sacar(500); // Saque com saldo suficiente
                Console.WriteLine($"Novo saldo: {conta.Saldo:F2}");

                conta.Sacar(800); // Tentativa de saque com saldo insuficiente
                Console.WriteLine($"Novo saldo: {conta.Saldo:F2}");
            }

            catch (ContaBancariaException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
