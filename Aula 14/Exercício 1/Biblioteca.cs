namespace Course
{
    // Definição da classe Biblioteca dentro do namespace Course
    public class Biblioteca
    {
        // Propriedade pública somente leitura para o nome da biblioteca
        public string Nome { get; private set; }

        // Lista privada de Livros pertencentes à biblioteca
        private List<Livro> Livros { get; set; }

        // Lista privada de Usuários registrados na biblioteca
        private List<Usuario> Usuarios { get; set; }

        // Construtor da classe Biblioteca, inicializa o nome, a lista de Livros e a lista de Usuários
        public Biblioteca(string nome)
        {
            Nome = nome;                      // Atribui o nome fornecido ao atributo Nome
            Livros = new List<Livro>();       // Inicializa a lista de Livros como uma nova lista vazia
            Usuarios = new List<Usuario>();   // Inicializa a lista de Usuários como uma nova lista vazia
        }

        // Método público para adicionar um Livro à biblioteca
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);                                        // Adiciona o livro à lista de Livros
            Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");  // Mensagem de feedback
        }

        // Método público para adicionar um Usuário à biblioteca
        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);                                   // Adiciona o usuário à lista de Usuários
            Console.WriteLine($"Usuário '{usuario.Nome}' adicionado à biblioteca.");  // Mensagem de feedback
        }

        // Método público para emprestar um livro da biblioteca para um usuário específico
        public void EmprestarLivro(string tituloLivro, int idUsuario)
        {
            // Busca o livro na lista de Livros pelo título fornecido
            Livro livro = Livros.Find(l => l.Titulo == tituloLivro);

            // Busca o usuário na lista de Usuários pelo ID fornecido
            Usuario usuario = Usuarios.Find(u => u.Id == idUsuario);

            // Verifica se tanto o livro quanto o usuário foram encontrados
            if (livro != null && usuario != null)
            {
                livro.Emprestar(usuario);  // Chama o método Emprestar do livro para emprestá-lo ao usuário
            }
            else
            {
                Console.WriteLine("Livro ou usuário não encontrado.");  // Mensagem de erro caso livro ou usuário não sejam encontrados
            }
        }

        // Método público para devolver um livro à biblioteca
        public void DevolverLivro(string tituloLivro)
        {
            // Busca o livro na lista de Livros pelo título fornecido
            Livro livro = Livros.Find(l => l.Titulo == tituloLivro);

            // Verifica se o livro foi encontrado
            if (livro != null)
            {
                livro.Devolver();  // Chama o método Devolver do livro para devolvê-lo à biblioteca
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");  // Mensagem de erro caso o livro não seja encontrado
            }
        }

        // Método público para listar todos os livros da biblioteca e seus status (disponível ou emprestado)
        public void ListarLivros()
        {
            Console.WriteLine("Lista de Livros:");

            // Itera sobre cada livro na lista de Livros
            foreach (var livro in Livros)
            {
                // Determina o status do livro com base na propriedade Disponivel e exibe na tela
                string status = livro.Disponivel ? "Disponível" : $"Emprestado para {livro.UsuarioEmprestado.Nome}";
                Console.WriteLine($"Título: {livro.Titulo}, Status: {status}");
            }
        }
    }
}
