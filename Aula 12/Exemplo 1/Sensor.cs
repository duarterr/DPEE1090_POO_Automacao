using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Sensor
    {
        // Método para ler dados de um sensor de temperatura
        public double LerDados(int idSensor)
        {
            // Simulação de leitura de dados do sensor de temperatura
            return 25.0; // Exemplo de retorno
        }

        // Método para ler dados de um sensor de pressão
        public double LerDados(int idSensor, string unidade)
        {
            // Simulação de leitura de dados do sensor de pressão
            return 101325.0; // Exemplo de retorno
        }

        // Método para ler dados de um sensor de umidade
        public double LerDados(int idSensor, string unidade, double precisao)
        {
            // Simulação de leitura de dados do sensor de umidade
            return 60.0; // Exemplo de retorno
        }
    }
}
