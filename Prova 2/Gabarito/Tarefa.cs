namespace Course
{
    public class Tarefa
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public TipoRobo Tipo { get; private set; }
        public Robo? RoboAlocado { get; private set; }
        public StatusTarefa Status { get; private set; }

        public Tarefa(int id, string descricao, TipoRobo tipo)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
            RoboAlocado = null;
            Status = StatusTarefa.Concluida;
        }

        public void Executar(Robo robo)
        {
            if (Status == StatusTarefa.Concluida && robo.Disponivel && robo.Tipo == Tipo)
            { 
                RoboAlocado = robo;
                Status = StatusTarefa.EmExecucao;

                Console.WriteLine("Tarefa " + Descricao + " alocada ao robo " + robo.Nome + ".");

                RoboAlocado.Iniciar();
            }
            else
            {
                Console.WriteLine("Erro. Robo " + robo.Nome + " não pode executar a tarefa " + Descricao + " ou a tarefa já está em execução.");
            }
        }

        public void Concluir()
        {
            if (RoboAlocado != null) 
            { 
                RoboAlocado.Parar();
                RoboAlocado = null;
                
                Status = StatusTarefa.Concluida;
                
                Console.WriteLine("Tarefa " + Descricao + " concluída.");
            }
            else
            {
                Console.WriteLine("Erro. Tarefa não está em execução.");
            }
        }
    }
}
