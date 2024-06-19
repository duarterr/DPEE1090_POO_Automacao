namespace Course
{
    // Classe interna Program
    internal class Program
    {
        // Método principal Main, que é o ponto de entrada do programa
        static void Main(string[] args)
        {
            // Criar componentes do carro
            Lataria lataria = new Lataria("Vermelha"); // Cria um objeto Lataria com cor "Vermelha"
            Motor motor = new Motor(150); // Cria um objeto Motor com potência 150 HP
            Roda roda1 = new Roda(15); // Cria um objeto Roda com tamanho de 15 polegadas
            Roda roda2 = new Roda(15); // Cria outro objeto Roda com tamanho de 15 polegadas
            Roda roda3 = new Roda(15); // Cria outro objeto Roda com tamanho de 15 polegadas
            Roda roda4 = new Roda(15); // Cria outro objeto Roda com tamanho de 15 polegadas
            Banco banco1 = new Banco("Couro"); // Cria um objeto Banco com material "Couro"
            Banco banco2 = new Banco("Couro"); // Cria outro objeto Banco com material "Couro"
            Banco banco3 = new Banco("Couro"); // Cria outro objeto Banco com material "Couro"

            // Criar carro e adicionar componentes
            Carro carro = new Carro(lataria, motor); // Cria um objeto Carro com a lataria e motor criados acima
            carro.AdicionarRoda(roda1); // Adiciona a primeira roda ao carro
            carro.AdicionarRoda(roda2); // Adiciona a segunda roda ao carro
            carro.AdicionarRoda(roda3); // Adiciona a terceira roda ao carro
            carro.AdicionarRoda(roda4); // Adiciona a quarta roda ao carro
            carro.AdicionarBanco(banco1); // Adiciona o primeiro banco ao carro
            carro.AdicionarBanco(banco2); // Adiciona o segundo banco ao carro
            carro.AdicionarBanco(banco3); // Adiciona o terceiro banco ao carro

            // Exibir informações do carro
            Console.WriteLine(carro); // Imprime no console a representação string do objeto Carro
        }
    }
}
