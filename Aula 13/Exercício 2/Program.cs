namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool validInput = false;

            // Loop para garantir uma entrada válida
            while (!validInput)
            {
                try
                {
                    Console.Write("Digite um número inteiro para verificar se é primo: ");
                    number = int.Parse(Console.ReadLine());

                    // Verifica se o número é primo usando o método de extensão
                    bool isPrime = number.IsPrime();

                    Console.WriteLine($"{number} {(isPrime ? "é" : "não é")} primo.");

                    validInput = true;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Erro: Entrada inválida. Digite um número inteiro válido.");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Erro: O número digitado é muito grande ou muito pequeno.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }
        }
    }
}
