namespace Prova
{
    public class ConversorTemperatura
    {
        // Método para converter temperatura entre diferentes escalas
		// Método é estático pois cálculos realizados são estáticos
        public static double Converter(double temperatura, char unidadeOriginal, char unidadeDesejada)
        {
            // Declaração de uma variável para armazenar a temperatura intermediária em Celsius
            double temperaturaEmCelsius;

            // Converte a temperatura original para Celsius como ponto intermediário
            switch (unidadeOriginal)
            {
                case 'C':
                    // Se a unidade original é Celsius, a temperatura já está em Celsius
                    temperaturaEmCelsius = temperatura;
                    break;
                case 'F':
                    // Converte de Fahrenheit para Celsius usando a fórmula: (F - 32) * 5 / 9
                    temperaturaEmCelsius = (temperatura - 32) * 5 / 9;
                    break;
                case 'K':
                    // Converte de Kelvin para Celsius subtraindo 273.15
                    temperaturaEmCelsius = temperatura - 273.15;
                    break;
                default:
                    // Lança uma exceção se a unidade original não é reconhecida
                    // Será visto posteriormente. Basicamente manda uma "mensagem" para o programa principal
                    throw new ArgumentException("Unidade de medida original inválida.");
            }

            // Declaração de uma variável para armazenar a temperatura convertida
            double temperaturaConvertida;

            // Converte a temperatura de Celsius para a unidade desejada
            switch (unidadeDesejada)
            {
                case 'C':
                    // Se a unidade desejada é Celsius, a temperatura já está convertida
                    temperaturaConvertida = temperaturaEmCelsius;
                    break;
                case 'F':
                    // Converte de Celsius para Fahrenheit usando a fórmula: (C * 9 / 5) + 32
                    temperaturaConvertida = (temperaturaEmCelsius * 9 / 5) + 32;
                    break;
                case 'K':
                    // Converte de Celsius para Kelvin adicionando 273.15
                    temperaturaConvertida = temperaturaEmCelsius + 273.15;
                    break;
                default:
                    // Lança uma exceção se a unidade desejada não é reconhecida
                    // Será visto posteriormente. Basicamente manda uma "mensagem" para o programa principal
                    throw new ArgumentException("Unidade de medida desejada inválida.");
            }

            // Retorna a temperatura convertida
            return temperaturaConvertida;
        }

        // Sobrecarga do método Converter que recebe apenas a temperatura em Celsius
		// Método é estático pois cálculos realizados são estáticos
        public static double Converter(double temperaturaEmCelsius, char unidadeDesejada)
        {
            // Chama o método principal Converter, assumindo que a unidade original é Celsius
            return Converter(temperaturaEmCelsius, 'C', unidadeDesejada);
        }
    }
}
