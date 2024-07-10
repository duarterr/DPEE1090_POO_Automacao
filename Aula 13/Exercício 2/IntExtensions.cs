namespace System
{
    public static class IntExtensions
    {
        // Método de extensão para verificar se um número é primo
        public static bool IsPrime(this int number)
        {
            // Números menores ou iguais a 1 não são primos
            if (number <= 1)
            {
                return false;
            }

            // Verifica se o número é divisível por algum número além de 1 e ele mesmo
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
