// Program.cs
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica fabrica = new Fabrica("ROBO MASTER");

            fabrica.AdicionarLinhaDeProducao(1, "LINHA 1");
            fabrica.AdicionarLinhaDeProducao(2, "LINHA 2");

            Console.WriteLine();

            Robo robo1 = new RoboSoldagem(1, "SOLDADOR");
            Robo robo2 = new RoboPintura(2, "PINTOR");
            Robo robo3 = new RoboMontagem(3, "MONTADOR");
            Robo robo4 = new RoboTransporte(4, "TRANSPORTADOR");

            fabrica.AdicionarRoboALinhaDeProducao(1, robo1);
            fabrica.AdicionarRoboALinhaDeProducao(1, robo2);
            fabrica.AdicionarRoboALinhaDeProducao(2, robo3);
            fabrica.AdicionarRoboALinhaDeProducao(2, robo4);

            Console.WriteLine();

            Tarefa tarefa1 = new Tarefa(1, "SOLDAGEM", TipoRobo.Soldagem);
            Tarefa tarefa2 = new Tarefa(2, "PINTURA", TipoRobo.Pintura);
            Tarefa tarefa3 = new Tarefa(3, "MONTAGEM", TipoRobo.Montagem);
            Tarefa tarefa4 = new Tarefa(4, "TRANSPORTE", TipoRobo.Transporte);

            fabrica.AdicionarTarefaALinhaDeProducao(1, tarefa1);
            fabrica.AdicionarTarefaALinhaDeProducao(1, tarefa2);
            fabrica.AdicionarTarefaALinhaDeProducao(2, tarefa3);
            fabrica.AdicionarTarefaALinhaDeProducao(2, tarefa4);

            Console.WriteLine();

            fabrica.IniciarTarefa(1, 1, 1);
            fabrica.IniciarTarefa(1, 2, 2);
            fabrica.IniciarTarefa(2, 3, 3);
            fabrica.IniciarTarefa(2, 4, 4);

            Console.WriteLine();

            fabrica.ListarTarefas();

            Console.WriteLine();

            fabrica.ConcluirTarefa(1, 1);
            fabrica.ConcluirTarefa(2, 3);

            Console.WriteLine();

            fabrica.ListarTarefas();
        }
    }
}
