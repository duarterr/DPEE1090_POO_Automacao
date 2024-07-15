namespace Course
{
    // Definição da classe Biblioteca dentro do namespace Course
    public class Biblioteca
    {
        // Propriedade pública somente leitura para o nome da biblioteca
        public string Nome { get; private set; }

        // Lista privada de itens pertencentes à biblioteca
        private List<Item> Itens { get; set; }

        // Lista privada de Usuários registrados na biblioteca
        private List<Usuario> Usuarios { get; set; }

        // Construtor da classe Biblioteca, inicializa o nome, a lista de Itens e a lista de Usuários
        public Biblioteca(string nome)
        {
            Nome = nome;                      // Atribui o nome fornecido ao atributo Nome
            Itens = new List<Item>();           // Inicializa a lista de Itens como uma nova lista vazia
            Usuarios = new List<Usuario>();   // Inicializa a lista de Usuários como uma nova lista vazia
        }

        // Método para adicionar um Item (Livro ou Revista) à biblioteca
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
            Console.WriteLine($"Item '{item.Titulo}' adicionado à biblioteca.");
        }

        // Método público para adicionar um Usuário à biblioteca
        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);                                   // Adiciona o usuário à lista de Usuários
            Console.WriteLine($"Usuário '{usuario.Nome}' adicionado à biblioteca.");  // Mensagem de feedback
        }

        // Método para emprestar um item da biblioteca para um usuário específico
        public void Emprestar(string tituloItem, int idUsuario)
        {
            // Busca o item na lista de Itens pelo título fornecido
            Item item = Itens.Find(i => i.Titulo == tituloItem);

            // Busca o usuário na lista de Usuários pelo ID fornecido
            Usuario usuario = Usuarios.Find(u => u.Id == idUsuario);

            // Verifica se tanto o item quanto o usuário foram encontrados
            if (item != null && usuario != null)
            {
                item.Emprestar(usuario);  // Chama o método Emprestar do item para emprestá-lo ao usuário
            }
            else
            {
                Console.WriteLine("Item ou usuário não encontrado.");
            }
        }

        // Método para devolver um item à biblioteca
        public void Devolver(string tituloItem)
        {
            // Busca o item na lista de Itens pelo título fornecido
            Item item = Itens.Find(i => i.Titulo == tituloItem);

            // Verifica se o item foi encontrado
            if (item != null)
            {
                item.Devolver();  // Chama o método Devolver do item para devolvê-lo à biblioteca
            }
            else
            {
                Console.WriteLine("Item não encontrado.");
            }
        }

        // Método para listar todos os itens (Livros e Revistas) da biblioteca e seus status (disponível ou emprestado)
        public void ListarItens()
        {
            Console.WriteLine("Lista de Itens:");

            // Itera sobre cada item na lista de Itens
            foreach (var item in Itens)
            {
                // Determina o status do item com base na propriedade Disponivel e exibe na tela
                string status = item.Disponivel ? "Disponível" : $"Emprestado para {item.UsuarioEmprestado.Nome}";
                Console.WriteLine($"Título: {item.Titulo}, Status: {status}");
            }
        }
    }
}
