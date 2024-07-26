namespace Course
{
    public class Fabrica
    {
        public string Nome { get; private set; }
        public List<LinhaDeProducao> LinhasDeProducao { get; private set; }

        public Fabrica(string nome)
        {
            Nome = nome;
            LinhasDeProducao = new List<LinhaDeProducao>();
        }

        public void AdicionarLinhaDeProducao(int id, string nome)
        {
            LinhasDeProducao.Add(new LinhaDeProducao(id, nome));
            Console.WriteLine("Linha de produção " + nome + " adicionada à fábrica " + Nome + ".");
        }

        public void AdicionarRoboALinhaDeProducao(int idLinha, Robo robo)
        {
            LinhaDeProducao linha = LinhasDeProducao.Find(l => l.Id == idLinha);

            if (linha != null)
            {
                linha.AdicionarRobo(robo);
            }
            else
            {
                Console.WriteLine("Linha de produção não encontrada.");
            }
        }

        public void AdicionarTarefaALinhaDeProducao(int idLinha, Tarefa tarefa)
        {
            LinhaDeProducao linha = LinhasDeProducao.Find(l => l.Id == idLinha);

            if (linha != null)
            {
                linha.AdicionarTarefa(tarefa);
            }
            else
            {
                Console.WriteLine("Linha de produção não encontrada.");
            }
        }

        public void IniciarTarefa(int idLinha, int idTarefa, int idRobo)
        {
            LinhaDeProducao linha = LinhasDeProducao.Find(l => l.Id == idLinha);

            if (linha != null)
            {
                linha.IniciarTarefa(idTarefa, idRobo);
            }
            else
            {
                Console.WriteLine("Linha de produção não encontrada.");
            }
        }

        public void ConcluirTarefa(int idLinha, int idTarefa)
        {
            LinhaDeProducao linha = LinhasDeProducao.Find(l => l.Id == idLinha);
            if (linha != null)
            {
                linha.ConcluirTarefa(idTarefa);
            }
            else
            {
                Console.WriteLine("Linha de produção não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            foreach (var linha in LinhasDeProducao)
            {
                linha.ListarTarefas();
            }
        }
    }
}
