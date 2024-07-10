namespace System
{
    // Classe estática para conter métodos de extensão
    public static class DateTimeExtensions
    {
        // Método de extensão para a classe DateTime
        // Este método calcula o tempo decorrido desde a data e hora fornecida até o momento atual
        public static string ElapsedTime(this DateTime dt)
        {
            // Calcula a duração entre a data/hora atual e a data/hora fornecida (dt)
            TimeSpan duration = DateTime.Now.Subtract(dt);

            // Se a duração for menor que 24 horas, retorna a duração em horas
            if (duration.TotalHours < 24.0)
                return $"{duration.TotalHours:F1} hours"; // Formata a saída para 1 casa decimal
            else
                // Caso contrário, retorna a duração em dias
                return $"{duration.TotalDays:F1} days"; // Formata a saída para 1 casa decimal
        }
    }
}
