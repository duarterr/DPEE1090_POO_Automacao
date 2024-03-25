using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Exercício 2
            // ------------------------------------------------------------------------------------------ //

            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double imposto;

            // Faixa isenta
            if (salario <= 2000)
                imposto = 0;

            // Segunda faixa - Paga apenas sobre excedente de 2000
            else if (salario <= 3000)
                imposto = (salario - 2000) * 0.08;

            // Terceira faixa - Paga sobre excedente de 3000 + 1000 na faixa 2
            else if (salario <= 4500)
                imposto = (salario - 3000) * 0.18 + 1000.0 * 0.08;

            // Quarta faixa - Paga sobre excedente de 4500 + 1000 na faixa 2 e 1500 na faixa 3
            else
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000.0 * 0.08;

            Console.WriteLine("Imposto devido: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}