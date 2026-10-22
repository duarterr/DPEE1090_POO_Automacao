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

            // Criação de uma Editora para as Revistas
            Editora editora1 = new Editora("Editora A", "1234567890001");

            // Criação de instâncias de Livro e Revista
            Livro livro1 = new Livro("Livro 1", new List<Autor> { new Autor(1, "Autor A") }, 2020, Genero.Ficcao);
            Revista revista1 = new Revista("Revista 1", editora1, 2021, Genero.Ciencia);

            // Criação de Usuários da biblioteca
            Usuario usuario1 = new Usuario(1, "Usuário 1");
            Usuario usuario2 = new Usuario(2, "Usuário 2");

            // Adição de itens (Livros e Revistas) à biblioteca
            biblioteca.AdicionarItem(livro1);
            biblioteca.AdicionarItem(revista1);

            // Adição de Usuários à biblioteca
            biblioteca.AdicionarUsuario(usuario1);
            biblioteca.AdicionarUsuario(usuario2);

            // Listagem de todos os itens da biblioteca
            biblioteca.ListarItens();

            // Operações de empréstimo de itens
            biblioteca.Emprestar("Livro 1", 1);
            biblioteca.Emprestar("Revista 1", 2);
            biblioteca.Emprestar("Item X", 1);

            // Listagem de itens após as operações de empréstimo
            biblioteca.ListarItens();

            // Operações de devolução de itens
            biblioteca.Devolver("Item X");
            biblioteca.Devolver("Livro 1");

            // Listagem de itens após as operações de devolução
            biblioteca.ListarItens();
        }
    }
}
