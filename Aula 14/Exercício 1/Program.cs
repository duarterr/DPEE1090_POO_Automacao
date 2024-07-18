namespace Course
{
    // Definição da classe Program dentro do namespace Course
    public class Program
    {
        // Método principal, ponto de entrada da aplicação
        static void Main(string[] args)
        {
            // Criação de uma nova instância de Biblioteca com o nome "Biblioteca Central"
            Biblioteca biblioteca = new Biblioteca("Biblioteca Central");

            // Criação de dois autores
            Autor autor1 = new Autor(1, "Autor A");
            Autor autor2 = new Autor(2, "Autor B");

            // Criação de dois livros, cada um com seus autores, ano de publicação e gênero
            Livro livro1 = new Livro("Livro 1", new List<Autor> { autor1, autor2 }, 2020, Genero.Ficcao);
            Livro livro2 = new Livro("Livro 2", new List<Autor> { autor1 }, 2018, Genero.Romance);

            // Criação de dois usuários da biblioteca
            Usuario usuario1 = new Usuario(1, "Usuário 1");
            Usuario usuario2 = new Usuario(2, "Usuário 2");

            // Adição dos livros criados à biblioteca
            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);

            // Adição dos usuários criados à biblioteca
            biblioteca.AdicionarUsuario(usuario1);
            biblioteca.AdicionarUsuario(usuario2);

            // Listagem dos livros disponíveis na biblioteca
            biblioteca.ListarLivros();

            // Operações de empréstimo de livros
            biblioteca.EmprestarLivro("Livro 1", 1);  // Livro 1 emprestado para usuário com Id 1 (usuario1)
            biblioteca.EmprestarLivro("Livro 1", 2);  // Tentativa de emprestar Livro 1 para usuário com Id 2 (usuario2)
            biblioteca.EmprestarLivro("Livro X", 1);  // Tentativa de emprestar Livro X para usuário com Id 1 (usuario1)

            // Listagem dos livros após as operações de empréstimo
            biblioteca.ListarLivros();

            // Operações de devolução de livros
            biblioteca.DevolverLivro("Livro X");  // Tentativa de devolver Livro X à biblioteca
            biblioteca.DevolverLivro("Livro 1");  // Devolução do Livro 1 à biblioteca

            // Listagem dos livros após as operações de devolução
            biblioteca.ListarLivros();
        }
    }
}
