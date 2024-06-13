namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste de conversões diretas entre diferentes unidades
            Console.WriteLine("Teste de conversões diretas entre diferentes unidades:");
            Console.WriteLine($"25°C para Fahrenheit: {ConversorTemperatura.Converter(25, 'C', 'F')}°F");
            Console.WriteLine($"25°C para Kelvin: {ConversorTemperatura.Converter(25, 'C', 'K')}K");
            Console.WriteLine($"77°F para Celsius: {ConversorTemperatura.Converter(77, 'F', 'C')}°C");
            Console.WriteLine($"77°F para Kelvin: {ConversorTemperatura.Converter(77, 'F', 'K')}K");
            Console.WriteLine($"300K para Celsius: {ConversorTemperatura.Converter(300, 'K', 'C')}°C");
            Console.WriteLine($"300K para Fahrenheit: {ConversorTemperatura.Converter(300, 'K', 'F')}°F");

            // Teste de conversões usando a sobrecarga que assume Celsius como unidade original
            Console.WriteLine("\nTeste de conversões usando a sobrecarga que assume Celsius como unidade original:");
            Console.WriteLine($"25°C para Fahrenheit: {ConversorTemperatura.Converter(25, 'F')}°F");
            Console.WriteLine($"25°C para Kelvin: {ConversorTemperatura.Converter(25, 'K')}K");

            // Teste de conversões inválidas
            // Comandos try catch serão vistos posteriormente. Estão aqui apenas para validar classe
            Console.WriteLine("\nTeste de conversões inválidas:");
            try
            {
                Console.WriteLine($"Conversão inválida: {ConversorTemperatura.Converter(25, 'C', 'X')}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine($"Conversão inválida: {ConversorTemperatura.Converter(25, 'X', 'C')}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine($"Conversão inválida: {ConversorTemperatura.Converter(25, 'X')}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
