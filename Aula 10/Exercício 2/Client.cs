// Define o namespace do projeto
namespace Course
{
    // A classe Client é interna, o que significa que só é acessível dentro do mesmo assembly
    internal class Client
    {
        // Propriedade pública para armazenar o nome do cliente
        public string Name { get; private set; }

        // Propriedade pública para armazenar o email do cliente
        public string Email { get; private set; }

        // Propriedade pública para armazenar a data de nascimento do cliente
        public DateTime BirthDate { get; private set; }

        // Construtor padrão que não faz nada específico
        public Client()
        {
        }

        // Construtor que inicializa as propriedades com os valores fornecidos como argumentos
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name; // Inicializa a propriedade Name com o valor do argumento name
            Email = email; // Inicializa a propriedade Email com o valor do argumento email
            BirthDate = birthDate; // Inicializa a propriedade BirthDate com o valor do argumento birthDate
        }

        // Sobrescreve o método ToString para fornecer uma representação em string personalizada do objeto Client
        public override string ToString()
        {
            // Retorna uma string que inclui o nome, a data de nascimento formatada e o email do cliente
            return $"{Name} ({BirthDate:dd/MM/yyyy}) - {Email}";
        }
    }
}
