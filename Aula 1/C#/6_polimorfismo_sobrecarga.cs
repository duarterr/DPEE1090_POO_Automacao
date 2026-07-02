namespace Course
{
    // NOTA: Diferente do JavaScript, o C# permite múltiplos métodos com o
    // mesmo nome na mesma classe, desde que com assinaturas diferentes

    // Classe
    internal class Calculadora
    {
        // Método soma dois números
        public double Soma(double a, double b)
        {
            return a + b;
        }

        // Sobrecarga: mesmo nome, assinatura diferente (três parâmetros)
        public double Soma(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto
            Calculadora calc = new Calculadora();

            // O compilador escolhe a versão correta pela quantidade de argumentos
            Console.WriteLine(calc.Soma(1, 2));
            Console.WriteLine(calc.Soma(1, 2, 3));
        }
    }
}
