using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        // Método principal da aplicação.
        static void Main(string[] args)
        {
            // Cria uma nova instância da classe DayPrinter.
            DayPrinter Printer = new DayPrinter();  

            // Loop de 1 a 8 para testar cada dia da semana.
            for (int i = 1; i <= 8; i++)
                // Imprime o nome do dia da semana para o valor de i.
                Console.WriteLine(Printer.GetDayOfWeek(i));  
        }
    }
}
