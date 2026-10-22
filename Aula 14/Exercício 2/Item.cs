namespace Course
{
    // Classe base para Livro e Revista
    public abstract class Item : IItemEmprestavel
    {
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public Genero Genero { get; private set; }
        public bool Disponivel { get; private set; }
        public Usuario UsuarioEmprestado { get; private set; }

        // Construtor da classe base Item
        public Item(string titulo, int ano, Genero genero)
        {
            Titulo = titulo;
            Ano = ano;
            Genero = genero;
            Disponivel = true;
            UsuarioEmprestado = null;
        }

        // Implementação do método Emprestar da interface IItemEmprestavel
        public void Emprestar(Usuario usuario)
        {
            if (Disponivel)
            {
                Disponivel = false;
                UsuarioEmprestado = usuario;
                Console.WriteLine($"'{Titulo}' emprestado para {usuario.Nome}.");
            }
            else
            {
                Console.WriteLine($"'{Titulo}' não está disponível para empréstimo.");
            }
        }

        // Implementação do método Devolver da interface IItemEmprestavel
        public void Devolver()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine($"'{Titulo}' devolvido por {UsuarioEmprestado.Nome}.");
                UsuarioEmprestado = null;
            }
            else
            {
                Console.WriteLine($"'{Titulo}' já está disponível na biblioteca.");
            }
        }
    }
}
