namespace Course
{
    // Define uma classe abstrata chamada Shape (Forma)
    abstract class Shape
    {
        // Propriedades somente leitura: só podem ser atribuídas no construtor
        public int NumSides { get; }
        public string Color { get; }

        // Construtor protegido: só pode ser chamado pelas subclasses (a classe abstrata não pode ser instanciada)
        protected Shape(int numSides, string color)
        {
            NumSides = numSides;
            Color = color;
        }

        // Método concreto: tem implementação na própria classe abstrata e é herdado pelas subclasses.
        // Note que ele chama GetArea(), que é abstrato: cada subclasse fornecerá a sua implementação
        public string Describe()
        {
            return $"{Color} shape with {NumSides} sides, area {GetArea()}";
        }

        // Método abstrato para calcular a área da forma (deve ser implementado nas classes derivadas)
        public abstract double GetArea();

        // Método abstrato para calcular o perímetro da forma (deve ser implementado nas classes derivadas)
        public abstract double GetPerimeter();
    }
}
