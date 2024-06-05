namespace Course
{
    internal class Program
    {
        // Método principal da aplicação, o ponto de entrada do programa.
        static void Main(string[] args)
        {
            // Criação de uma lista de funcionários. 
            // Uma lista é uma coleção que pode armazenar múltiplos objetos do mesmo tipo, neste caso, objetos da classe Employee ou suas subclasses.
            List<Employee> employees = new List<Employee>();

            // Adição de funcionários à lista.
            // O método Add é usado para adicionar um novo objeto à lista.
            // Aqui, estamos criando instâncias de HourContract e SalariedEmployee e adicionando-as à lista.
            employees.Add(new HourContract(1, "Alice", 1000.0, 20, 50.0)); // Adiciona um contrato por hora com ID 1, nome Alice, salário base 1000.0, 20 horas trabalhadas e valor por hora de 50.0
            employees.Add(new SalariedEmployee(2, "Bob", 1200.0, 3000.0)); // Adiciona um funcionário assalariado com ID 2, nome Bob, salário base 1200.0 e salário mensal de 3000.0
            employees.Add(new HourContract(3, "Charlie", 800.0, 10, 40.0)); // Adiciona um contrato por hora com ID 3, nome Charlie, salário base 800.0, 10 horas trabalhadas e valor por hora de 40.0
            employees.Add(new SalariedEmployee(4, "Dave", 1100.0, 2500.0)); // Adiciona um funcionário assalariado com ID 4, nome Dave, salário base 1100.0 e salário mensal de 2500.0

            // Exibição das informações dos funcionários.
            // Usamos um loop foreach para percorrer todos os elementos da lista.
            // Para cada elemento (employee) na lista, chamamos o método ShowInfo() para exibir suas informações.
            foreach (var employee in employees)
            {
                employee.ShowInfo();
            }
        }
    }
}
