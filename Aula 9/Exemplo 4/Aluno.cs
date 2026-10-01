namespace Course
{
    internal class Aluno
    {
        public string Nome { get; set; }

        public Aluno() { }
        public Aluno(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
