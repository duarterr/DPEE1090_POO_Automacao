namespace Course
{
    // Classe para validação de CPF
    internal class Cpf
    {
        public static bool Valida (string cpf)
        {
            int Soma = 0;
            int Verificador = 0;
            int Div = 0;
            int Resto = 0;

            // Checa se CPF recebido é nulo ou não tem 11 caracteres
            if (string.IsNullOrEmpty (cpf) || cpf.Length != 11)
                return false;

            // Calculo do primeiro verificador
            for (int i = 0; i < 9; i++) 
                Soma += (_GetDigito(cpf, i) * (10 - i));

            Div = Soma / 11;
            Resto = Soma % 11;

            if (Div < 2)
                Verificador = 0;
            else
                Verificador = 11 - Resto;

            // Se verificador 1 é diferente do 10 numero do CPF recebido, CPF é inválido
            if (Verificador != _GetDigito(cpf, 9))
                return false;
            
            // Calculo do segundo verificador
            Soma = 0;
            for (int i = 0; i < 10; i++)
                Soma += (_GetDigito(cpf, i) * (11 - i));

            Div = Soma / 11;
            Resto = Soma % 11;

            if (Div < 2)
                Verificador = 0;
            else
                Verificador = 11 - Resto;

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
    }
}
