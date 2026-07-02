namespace Course
{
    // Classe
    internal class Calculadora
    {
        // Método soma dois números
        public double Soma(double a, double b)
        {
            return a + b;
        }

        // Método multiplica dois números
        public double Multiplica(double a, double b)
        {
            return a * b;
        }

        // A implementação pode mudar sem afetar quem usa a interface:
        //public double Multiplica(double a, double b)
        //{
        //    a = a * 10;
        //    b = b * 100;
        //    return (a * b) / 1000;
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto
            Calculadora calc = new Calculadora();

            // O usuário da classe não precisa conhecer a implementação
            Console.WriteLine(calc.Soma(1, 2));
            Console.WriteLine(calc.Multiplica(2, 5));
        }
    }
}
