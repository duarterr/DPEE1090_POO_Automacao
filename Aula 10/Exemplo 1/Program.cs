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

            // Imprime um dia
            int Dia = 1;
            Console.WriteLine(Printer.GetDayOfWeek(Dia));
        }
    }
}
