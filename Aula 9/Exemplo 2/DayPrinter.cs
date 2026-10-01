namespace Course
{
    // A classe DayPrinter é interna, o que significa que só é acessível dentro do mesmo assembly.
    internal class DayPrinter
    {
        // O método GetDayOfWeek recebe um valor do tipo DayOfWeek e retorna o nome do dia correspondente.
        public string GetDayOfWeek(DayOfWeek day)
        {
            // Utiliza a estrutura switch para determinar o nome do dia com base no valor da enumeração.
            switch (day)
            {
                case DayOfWeek.SegundaFeira:
                    return "Segunda-feira"; // Retorna "Segunda-feira" se o valor de day for SegundaFeira.
                case DayOfWeek.TercaFeira:
                    return "Terça-feira";   // Retorna "Terça-feira" se o valor de day for TercaFeira.
                case DayOfWeek.QuartaFeira:
                    return "Quarta-feira";  // Retorna "Quarta-feira" se o valor de day for QuartaFeira.
                case DayOfWeek.QuintaFeira:
                    return "Quinta-feira";  // Retorna "Quinta-feira" se o valor de day for QuintaFeira.
                case DayOfWeek.SextaFeira:
                    return "Sexta-feira";   // Retorna "Sexta-feira" se o valor de day for SextaFeira.
                case DayOfWeek.Sabado:
                    return "Sábado";        // Retorna "Sábado" se o valor de day for Sabado.
                case DayOfWeek.Domingo:
                    return "Domingo";       // Retorna "Domingo" se o valor de day for Domingo.
                default:
                    return "Dia inválido!"; // Retorna "Dia inválido!" se o valor da enumeração não corresponder a nenhum dia.
            }
        }
    }
}
