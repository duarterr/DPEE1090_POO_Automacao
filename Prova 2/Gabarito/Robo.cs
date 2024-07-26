namespace Course
{
    public abstract class Robo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoRobo Tipo { get; private set; }
        public bool Disponivel { get; private set; }

        protected Robo(int id, string nome, TipoRobo tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Disponivel = true;
        }

        public void Iniciar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine("A tarefa foi inciada pelo robo " + Nome + ".");
            }
            else
            {
                Console.WriteLine("Robo " + Nome + " está indisponível.");
            }
        }

        public void Parar()
        {
            Disponivel = true;
            Console.WriteLine("Robo " + Nome + " concluiu a tarefa.");
        }
    }
}
