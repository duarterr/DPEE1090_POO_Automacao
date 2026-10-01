namespace Course
{
    // A classe DayPrinter é interna, o que significa que só é acessível dentro do mesmo assembly.
    internal class DayPrinter
    {
        // O método GetDayOfWeek recebe um inteiro representando o dia da semana e retorna o nome do dia correspondente.
        public string GetDayOfWeek(int day)
        {
            // A estrutura switch é usada para determinar qual dia da semana corresponde ao número fornecido.
            switch (day)
            {
                case 1:
                    return "Segunda-feira"; // Retorna "Segunda-feira" se o valor de day for 1.
                case 2:
                    return "Terça-feira";   // Retorna "Terça-feira" se o valor de day for 2.
                case 3:
                    return "Quarta-feira";  // Retorna "Quarta-feira" se o valor de day for 3.
                case 4:
                    return "Quinta-feira";  // Retorna "Quinta-feira" se o valor de day for 4.
                case 5:
                    return "Sexta-feira";   // Retorna "Sexta-feira" se o valor de day for 5.
                case 6:
                    return "Sábado";        // Retorna "Sábado" se o valor de day for 6.
                case 7:
                    return "Domingo";       // Retorna "Domingo" se o valor de day for 7.
                default:
                    return "Dia inválido!"; // Retorna "Dia inválido!" para qualquer valor fora do intervalo 1-7.
            }
        }
    }
}
