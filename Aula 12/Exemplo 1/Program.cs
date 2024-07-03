using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Sensor MySensor = new Sensor();

            // Demonstração de leitura de dados
            Console.WriteLine("Leitura de temperatura: " + MySensor.LerDados(1));
            Console.WriteLine("Leitura de pressão: " + MySensor.LerDados(2, "Pa"));
            Console.WriteLine("Leitura de umidade: " + MySensor.LerDados(3, "RH", 0.01));
        }
    }
}