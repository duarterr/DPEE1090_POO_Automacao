namespace Course
{
    // A classe SalariedEmployee é interna, ou seja, só pode ser acessada dentro do mesmo assembly.
    internal class SalariedEmployee : Employee
    {
        // Propriedade pública com getter e setter automático.

        // Salário mensal do funcionário.
        public double MonthlySalary { get; set; }

        // Construtor da classe SalariedEmployee, utilizado para inicializar as propriedades do objeto, incluindo as propriedades herdadas.
        public SalariedEmployee(int id, string name, double baseSalary, double monthlySalary)
            : base(id, name, baseSalary)
        {
            // Inicializa a propriedade MonthlySalary com o valor do parâmetro monthlySalary.
            MonthlySalary = monthlySalary;
        }

        // Sobrescrita do método Income para calcular o salário fixo mensal.
        public override double Income()
        {
            // Retorna o salário base mais o salário mensal.
            return BaseSalary + MonthlySalary;
        }

        // Sobrescrita do método ShowInfo para mostrar informações adicionais sobre o funcionário com salário mensal.
        public override void ShowInfo()
        {
            // Chama o método ShowInfo da classe base (Employee) para exibir as informações básicas.
            base.ShowInfo();

            // Exibe o salário mensal do funcionário.
            Console.WriteLine($"Salário Mensal: {MonthlySalary}");

            // Exibe a renda total do funcionário.
            Console.WriteLine($"Renda Total: {Income()}\n");
        }
    }
}
