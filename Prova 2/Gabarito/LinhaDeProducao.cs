namespace Course
{
    public class LinhaDeProducao
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Robo> Robos { get; private set; }
        public List<Tarefa> Tarefas { get; private set; }

        public LinhaDeProducao(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Robos = new List<Robo>();
            Tarefas = new List<Tarefa>();
        }

        public void AdicionarRobo(Robo robo)
        {
            Robos.Add(robo);
            Console.WriteLine("Robo " + robo.Nome + " adicionado à linha de produção " + Nome + ".");
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
            Console.WriteLine("Tarefa " + tarefa.Descricao + " adicionada à linha de produção " + Nome + ".");
        }

        public void IniciarTarefa(int idTarefa, int idRobo)
        {
            Tarefa tarefa = Tarefas.Find(t => t.Id == idTarefa);
            Robo robo = Robos.Find(r => r.Id == idRobo);

            if (tarefa != null && robo != null)
            {
                tarefa.Executar(robo);
            }
            else
            {
                Console.WriteLine("Erro ao inciar tarefa. Verifique se os IDs são válidos.");
            }
        }

        public void ConcluirTarefa(int idTarefa)
        {
            Tarefa tarefa = Tarefas.Find(t => t.Id == idTarefa);

            if (tarefa != null)
            {
                tarefa.Concluir();
            }
            else
            {
                Console.WriteLine("Erro ao concluir tarefa. Verifique se o ID da tarefa é válido.");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("Tarefas na linha de produção " + Nome + ":");
            foreach (var tarefa in Tarefas)
            {
                string status = tarefa.Status.ToString();
                string roboNome = tarefa.RoboAlocado != null ? tarefa.RoboAlocado.Nome : "Nenhum";
                Console.WriteLine("Tarefa " + tarefa.Descricao + ", Status: " + status + ", Robo Alocado: " + roboNome);
            }
        }
    }
}
