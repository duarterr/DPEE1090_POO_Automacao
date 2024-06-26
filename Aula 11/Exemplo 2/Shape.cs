namespace Course
{
    // Define uma classe abstrata chamada Shape (Forma)
    abstract class Shape
    {
        // Campo protegido para armazenar o número de lados
        protected int _numSides;

        // Campo protegido para armazenar a cor
        protected string _color;

        // Construtor que inicializa o número de lados
        public Shape(int numSides, string color)
        {
            _numSides = numSides;
            _color = color;
        }

        // Método público para obter o número de lados
        public int GetNumSides()
        {
            return _numSides;
        }

        // Método abstrato para calcular a área da forma (deve ser implementado nas classes derivadas)
        public abstract double GetArea();

        // Método abstrato para calcular o perímetro da forma (deve ser implementado nas classes derivadas)
        public abstract double GetPerimeter();
    }
}
