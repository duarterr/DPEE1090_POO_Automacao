namespace Course
{
    // Classe Livro que herda de Item
    public class Livro : Item
    {
        public List<Autor> Autores { get; private set; }

        // Construtor da classe Livro que inicializa os atributos de Item e os específicos de Livro
        public Livro(string titulo, List<Autor> autores, int ano, Genero genero) : base(titulo, ano, genero)
        {
            Autores = autores;
        }
    }
}
