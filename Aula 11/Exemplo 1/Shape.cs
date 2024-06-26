namespace Curso
{
    // Define uma classe abstrata chamada Shape (Forma)
    abstract class Shape
    {
        // Campo protegido para armazenar o número de lados
        protected int _numSides;

        // Construtor que inicializa o número de lados
        public Shape(int numSides)
        {
            _numSides = numSides;
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
