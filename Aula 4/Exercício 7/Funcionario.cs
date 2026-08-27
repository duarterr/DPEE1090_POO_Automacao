using System.Globalization;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Porcentagem)
        {
            SalarioBruto *= (100 + Porcentagem)/100;
        }
    }
}