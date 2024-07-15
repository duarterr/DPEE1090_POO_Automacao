namespace Course
{
    // Definição da classe Livro que implementa a interface IItemEmprestavel
    public class Livro : IItemEmprestavel
    {
        // Propriedade pública somente leitura para o título do livro
        public string Titulo { get; private set; }

        // Propriedade pública somente leitura para a lista de autores do livro
        public List<Autor> Autores { get; private set; }

        // Propriedade pública somente leitura para o ano de publicação do livro
        public int Ano { get; private set; }

        // Propriedade pública somente leitura para o gênero do livro, utilizando o enum Genero
        public Genero Genero { get; private set; }

        // Propriedade pública somente leitura para indicar se o livro está disponível para empréstimo
        public bool Disponivel { get; private set; }

        // Propriedade pública somente leitura para armazenar o usuário que pegou o livro emprestado
        public Usuario UsuarioEmprestado { get; private set; }

        // Construtor da classe Livro, inicializa os atributos do livro
        public Livro(string titulo, List<Autor> autores, int ano, Genero genero)
        {
            Titulo = titulo;               // Atribui o título fornecido ao atributo Titulo
            Autores = autores;             // Atribui a lista de autores fornecida ao atributo Autores
            Ano = ano;                     // Atribui o ano fornecido ao atributo Ano
            Genero = genero;               // Atribui o gênero fornecido ao atributo Genero
            Disponivel = true;             // Inicialmente, o livro está disponível para empréstimo
            UsuarioEmprestado = null;      // Inicialmente, nenhum usuário pegou o livro emprestado
        }

        // Implementação do método Emprestar da interface IItemEmprestavel
        public void Emprestar(Usuario usuario)
        {
            if (Disponivel)
            {
                Disponivel = false;                           // Marca o livro como indisponível
                UsuarioEmprestado = usuario;                  // Associa o usuário ao livro emprestado
                Console.WriteLine($"Livro '{Titulo}' emprestado para {usuario.Nome}.");  // Mensagem de feedback
            }
            else
            {
                Console.WriteLine($"Livro '{Titulo}' não está disponível para empréstimo.");  // Mensagem de feedback
            }
        }

        // Implementação do método Devolver da interface IItemEmprestavel
        public void Devolver()
        {
            if (!Disponivel)
            {
                Disponivel = true;                                             // Marca o livro como disponível
                Console.WriteLine($"Livro '{Titulo}' devolvido por {UsuarioEmprestado.Nome}.");  // Mensagem de feedback
                UsuarioEmprestado = null;                                       // Remove a associação do usuário
            }
            else
            {
                Console.WriteLine($"Livro '{Titulo}' já está disponível na biblioteca.");  // Mensagem de feedback
            }
        }
    }
}
