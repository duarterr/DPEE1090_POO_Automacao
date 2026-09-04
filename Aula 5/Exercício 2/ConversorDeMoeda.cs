namespace Course
{
    internal class ConversorDeMoeda
    {
        // Valor do Iof
        public static double Iof = 0.06;

        // Método para converter dolares em reais
        public static double DolarParaReal(double quantidade, double cotacao)
        {
            return (quantidade * cotacao)*(1.0 + Iof);            
        }
    }
}
