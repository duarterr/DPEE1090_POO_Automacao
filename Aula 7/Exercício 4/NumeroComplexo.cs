namespace Course
{
    // Classe NumeroComplexo
    internal class NumeroComplexo
    {
        // Atributos do numero. Props
        public double Real { get; set; }
        public double Imag { get; set; }

        // Construtor que recebe apenas a parte real
        public NumeroComplexo(double real) 
        {
            Real = real;
            Imag = 0;
        }

        // Construtor que recebe os dois parametros. 
        // Para evitar repetição de código, esse contrutor invoca o acima para 
        // definir a parte real
        public NumeroComplexo(double real, double imag) : this(real)
        {
            Imag = imag;
        }

        // Método para soma
        public void Soma (NumeroComplexo num)
        {
            Real += num.Real;
            Imag += num.Imag;
        }

        // Método para subtração
        public void Subtracao(NumeroComplexo num)
        {
            Real -= num.Real;
            Imag -= num.Imag;
        }

        // Método para comparação de dois numeros complexos
        public override bool Equals(object? obj)
        {
            // Verifica se obj é um NumeroComplexo. Se sim, salva como "complexo" e compara
            // cada parte
            return obj is NumeroComplexo complexo &&
                   Real == complexo.Real &&
                   Imag == complexo.Imag;
        }

        // Método para imprimir no formato (R, I)
        public override string ToString()
        {
            return "(" + Real.ToString() + ", " + Imag.ToString() + ")";
        }


    }
}
    