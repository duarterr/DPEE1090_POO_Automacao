using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objetos Funcionaio
            Funcionario func = new Funcionario();

            // Pega com usuario dados do funcionario
            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Exibe dados digitados
            Console.WriteLine("Funcionario: " + func.Nome + ", $" + func.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            // Aumento de salário
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(aumento);

            // Exibe dados atualizados
            Console.WriteLine("Dados atualizados: " + func.Nome + ", $" + func.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}