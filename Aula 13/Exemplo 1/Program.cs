namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "Extension methods são muito úteis!";
            string frase2 = "Eles permitem adicionar funcionalidade sem modificar código existente.";
            string frase3 = "C# é uma linguagem poderosa.";
            string frase4 = "";

            Console.WriteLine($"Número de palavras na frase 1: {frase1.ContarPalavras()}");
            Console.WriteLine($"Número de palavras na frase 2: {frase2.ContarPalavras()}");
            Console.WriteLine($"Número de palavras na frase 3: {frase3.ContarPalavras()}");
            Console.WriteLine($"Número de palavras na frase 4: {frase4.ContarPalavras()}");
        }
    }
}