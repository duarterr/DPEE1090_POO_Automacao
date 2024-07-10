namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de uma variável para o leitor de arquivos
            StreamReader leitor = null;
            // Caminho do arquivo de configuração
            string caminhoArquivo = "Config.txt";

            try
            {
                // Tentativa de abrir o arquivo de configuração para leitura
                leitor = new StreamReader(caminhoArquivo);
                // Leitura do conteúdo do arquivo
                string conteudo = leitor.ReadToEnd();
                // Exibição do conteúdo lido no console
                Console.WriteLine("Configurações carregadas com sucesso:");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException ex)
            {
                // Tratamento para o caso de o arquivo não ser encontrado
                Console.WriteLine($"Erro: O arquivo '{caminhoArquivo}' não foi encontrado.");
            }
            catch (UnauthorizedAccessException ex)
            {
                // Tratamento para o caso de falta de permissão para acessar o arquivo
                Console.WriteLine($"Erro: Acesso ao arquivo '{caminhoArquivo}' negado.");
            }
            catch (Exception ex)
            {
                // Tratamento para qualquer outra exceção
                Console.WriteLine($"Erro: Ocorreu um erro ao carregar o arquivo de configuração. Detalhes: {ex.Message}");
            }
            finally
            {
                // Bloco finally garante que o arquivo seja fechado, independentemente de ocorrer uma exceção ou não
                if (leitor != null)
                {
                    leitor.Close();
                    Console.WriteLine("Arquivo de configuração fechado.");
                }
            }
        }
    }
}
