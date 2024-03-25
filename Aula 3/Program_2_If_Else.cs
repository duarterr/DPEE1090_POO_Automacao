using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------------ //
            // Estruturas condicionais if-else
            // ------------------------------------------------------------------------------------------ //

            Console.Write("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            // Solução 1 - If simples. Não é eficiente pois cada condição será checada mesmo que anterior
            // ja tenha sido validada. Além disso, codigo fica mais vulnerável a erros do programador. Ex:
            // Código abaixo não contempla hora = 12
            if (hora < 12)
                Console.WriteLine("Bom dia");
            if (hora > 12 && hora < 18)
                Console.WriteLine("Boa tarde");
            if (hora > 18)
                Console.WriteLine("Boa noite");

            // Solução 2 - Encadeada. Executa somente porção em que lógica é verdadeira
            if (hora < 12)
                Console.WriteLine("Bom dia");
            else if (hora < 18)
                Console.WriteLine("Boa tarde");
            else
                Console.WriteLine("Boa noite");

            // ------------------------------------------------------------------------------------------ //
            // Operador ternario
            // ------------------------------------------------------------------------------------------ //

            string ehPar = hora % 2 == 0 ? "par" : "impar";
            Console.WriteLine("Hora digitada é " + ehPar);

            // ------------------------------------------------------------------------------------------ //
            // Escopo e inicialização de variaveis
            // ------------------------------------------------------------------------------------------ //

            // Caso 1 - Variável desconto não existe fora do escopo do if
            /*
            double preco = 100;

            if (preco > 100)
            {
                double desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            */

            // Caso 2 - Variável desconto existe fora do escopo do if, mas pode nao estar inicializada
            /*
            double preco = 100;
            double desconto;

            if (preco > 100)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            */
        }
    }
}