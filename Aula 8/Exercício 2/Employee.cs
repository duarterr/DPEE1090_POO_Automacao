namespace Course
{
    // A classe Employee é interna, ou seja, só pode ser acessada dentro do mesmo assembly.
    internal class Employee
    {
        // Propriedades públicas com getters e setters automáticos.

        // Identificador único do funcionário.
        public int Id { get; set; }

        // Nome do funcionário.
        public string Name { get; set; }

        // Salário base do funcionário.
        public double BaseSalary { get; set; }

        // Construtor da classe Employee, utilizado para inicializar as propriedades do objeto.
        public Employee(int id, string name, double baseSalary)
        {
            // Inicializa a propriedade Id com o valor do parâmetro id.
            Id = id;

            // Inicializa a propriedade Name com o valor do parâmetro name.
            Name = name;

            // Inicializa a propriedade BaseSalary com o valor do parâmetro baseSalary.
            BaseSalary = baseSalary;
        }

        // Método virtual que pode ser sobrescrito em classes derivadas para calcular o salário total do funcionário.
        // Por padrão, ele retorna o salário base.
        public virtual double Income()
        {
            return BaseSalary;
        }

        // Método virtual para mostrar as informações do funcionário.
        // Pode ser sobrescrito em classes derivadas para exibir informações adicionais.
        public virtual void ShowInfo()
        {
            // Exibe o identificador do funcionário.
            Console.WriteLine($"ID: {Id}");

            // Exibe o nome do funcionário.
            Console.WriteLine($"Nome: {Name}");

            // Exibe o salário base do funcionário.
            Console.WriteLine($"Salário Base: {BaseSalary}");
        }
    }
}
