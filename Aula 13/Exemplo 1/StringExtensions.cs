namespace System
{
    // Classe estática para conter métodos de extensão
    public static class StringExtensions
    {
        // Método de extensão para contar palavras em uma string
        public static int ContarPalavras(this string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return 0;

            return 
                str.Split(' ').Length;
        }
    }
}
