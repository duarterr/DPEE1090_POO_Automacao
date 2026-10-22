namespace Course
{
    // Classe Revista que herda de Item
    public class Revista : Item
    {
        public Editora Editora { get; private set; }

        // Construtor da classe Revista que inicializa os atributos de Item e os específicos de Revista
        public Revista(string titulo, Editora editora, int ano, Genero genero) : base(titulo, ano, genero)
        {
            Editora = editora;
        }
    }
}
