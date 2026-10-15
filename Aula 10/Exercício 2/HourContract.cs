namespace Course
{
    // A classe HourContract é interna, ou seja, só pode ser acessada dentro do mesmo assembly.
    internal class HourContract : Employee
    {
        // Propriedades com leitura pública e escrita privada: só são definidas no construtor.

        // Quantidade de horas trabalhadas.
        public int Hours { get; private set; }

        // Valor da hora de trabalho.
        public double HourValue { get; private set; }

        // Construtor da classe HourContract, utilizado para inicializar as propriedades do objeto, incluindo as propriedades herdadas.
        public HourContract(int id, string name, double baseSalary, int hours, double hourValue)
            : base(id, name, baseSalary)
        {
            // Inicializa a propriedade Hours com o valor do parâmetro hours.
            Hours = hours;

            // Inicializa a propriedade HourValue com o valor do parâmetro hourValue.
            HourValue = hourValue;
        }

        // Sobrescrita do método Income para calcular o salário baseado nas horas trabalhadas.
        public override double Income()
        {
            // Retorna o salário base mais o valor total das horas trabalhadas.
            return BaseSalary + (Hours * HourValue);
        }

        // Sobrescrita do método ShowInfo para mostrar informações adicionais sobre o funcionário por hora.
        public override void ShowInfo()
        {
            // Chama o método ShowInfo da classe base (Employee) para exibir as informações básicas.
            // Além de chamar construtores, a palavra base também permite chamar métodos da superclasse.
            base.ShowInfo();

            // Exibe a quantidade de horas trabalhadas.
            Console.WriteLine($"Horas Trabalhadas: {Hours}");

            // Exibe o valor da hora de trabalho.
            Console.WriteLine($"Valor da Hora: {HourValue}");

            // Exibe a renda total do funcionário.
            Console.WriteLine($"Renda Total: {Income()}\n");
        }
    }
}
