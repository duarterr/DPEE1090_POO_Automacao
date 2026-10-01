namespace Course
{
    // Classe interna Program
    internal class Program
    {
        // Método principal Main, que é o ponto de entrada do programa
        static void Main(string[] args)
        {
            // Exemplo de Enum.Parse: Convertendo uma string para o enum
            Console.WriteLine("Exemplo de Enum.Parse:");
            string dayString = "QuartaFeira";
            DayOfWeek parsedDay = Enum.Parse<DayOfWeek>(dayString);
            Console.WriteLine($"String '{dayString}' convertida para enum: {parsedDay}");
            Console.WriteLine();

            // Exemplo de Enum.TryParse: Tentando converter uma string para o enum
            Console.WriteLine("Exemplo de Enum.TryParse:");
            string dayString2 = "TercaFeira";
            if (Enum.TryParse<DayOfWeek>(dayString2, out DayOfWeek parsedDay2))
            {
                Console.WriteLine($"String '{dayString2}' convertida com sucesso para enum: {parsedDay2}");
            }
            else
            {
                Console.WriteLine($"Não foi possível converter a string '{dayString2}' para enum.");
            }
            Console.WriteLine();

            // Exemplo de Enum.GetNames: Obtendo os nomes dos membros do enum
            Console.WriteLine("Exemplo de Enum.GetNames:");
            string[] dayNames = Enum.GetNames(typeof(DayOfWeek));
            Console.WriteLine("Nomes dos membros do enum DayOfWeek:");
            foreach (var name in dayNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Exemplo de Enum.GetValues: Obtendo os valores do enum
            Console.WriteLine("Exemplo de Enum.GetValues:");
            DayOfWeek[] days = (DayOfWeek[])Enum.GetValues(typeof(DayOfWeek));

            Console.WriteLine("Valores do enum DayOfWeek:");
            foreach (var X in days)
            {
                Console.WriteLine($"{X}: {(int)X}");
            }
            Console.WriteLine();
        }
    }
}
