namespace Course
{
    // Classe para validação de CPF
    internal class Cpf
    {
        public static bool Valida(string cpf)
        {
            // Checa se CPF recebido é nulo ou não tem 11 caracteres
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                return false;

            // Calcula verificador 1
            int Verificador = _CalculaVerificador(cpf, 1);

            // Se verificador 1 é diferente do 10 numero do CPF recebido, CPF é inválido
            if (Verificador != _GetDigito(cpf, 9))
                return false;

            // Calculo do segundo verificador
            Verificador = _CalculaVerificador(cpf, 2);

            // Se verificador é diferente do 11 numero do CPF recebido, CPF é inválido
            if (Verificador != _GetDigito(cpf, 10))
                return false;

            // Se chegamos até aqui, ambos os verificadores foram validados
            return true;
        }

        // Função auxiliar para converter um char da string CPF em inteiro
        private static int _GetDigito(string cpf, int index)
        {
            return int.Parse(cpf[index].ToString());
        }

        // Calculo dos verificadores (verificador = 1 para primeiro verificador, 2 para segundo)
        private static int _CalculaVerificador(string cpf, int verificador)
        {
            int Soma = 0;
            int Div = 0;
            int Resto = 0;

            for (int i = 0; i < (8 + verificador); i++)
                Soma += (_GetDigito(cpf, i) * (9 + verificador - i));

            Div = Soma / 11;
            Resto = Soma % 11;

            if (Div < 2)
                return 0;
            else
                return 11 - Resto;
        }
    }
}
