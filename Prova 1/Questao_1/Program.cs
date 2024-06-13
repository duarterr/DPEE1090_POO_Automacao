namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste 1: Criação de um retângulo válido
            Retangulo retangulo1 = new Retangulo(10, 20);
            Console.WriteLine($"Retângulo 1 - Largura: {retangulo1.Largura}, Altura: {retangulo1.Altura}, Área: {retangulo1.Area()}");

            // Teste 2: Tentativa de criação de um retângulo com largura inválida (150)
            Retangulo retangulo2 = new Retangulo(150, 20);
            Console.WriteLine($"Retângulo 2 - Largura: {retangulo2.Largura}, Altura: {retangulo2.Altura}, Área: {retangulo2.Area()}");

            // Teste 3: Tentativa de criação de um retângulo com altura inválida (150)
            Retangulo retangulo3 = new Retangulo(10, 150);
            Console.WriteLine($"Retângulo 3 - Largura: {retangulo3.Largura}, Altura: {retangulo3.Altura}, Área: {retangulo3.Area()}");

            // Teste 4: Tentativa de criação de um retângulo com ambos os lados inválidos
            Retangulo retangulo4 = new Retangulo(-5, 150);
            Console.WriteLine($"Retângulo 4 - Largura: {retangulo4.Largura}, Altura: {retangulo4.Altura}, Área: {retangulo4.Area()}");

            // Teste 5: Modificação das propriedades (não permitido)
            retangulo1.Altura = 150;
            retangulo1.Largura = 150;
            Console.WriteLine($"Retângulo 1 - Largura: {retangulo1.Largura}, Altura: {retangulo1.Altura}, Área: {retangulo1.Area()}");
        }
    }
}
