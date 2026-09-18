namespace Course
{
    // Classe triangulo
    internal class Triangle
    {
        // Lado do triangulo
        private double _side = 1.0;
        
        // Construtor 1 - Valor padrão (já definido)
        public Triangle() 
        {
        }

        // Construtor 2 - Recebe lado como parametro
        public Triangle(double side)
        {
            // Só será setado se valor for >= 0 e <= 20
            SetSide(side);
        }

        // Setter com validação
        public void SetSide(double side)
        {
            if (side >= 0.0 && side <= 20)
                _side = side;
        }

        // Getter
        public double GetSide() 
        { 
            return _side;
        }

        // área
        public double Area()
        { 
            return (Math.Sqrt(3)/4.0) * Math.Pow(_side, 2);
        }

        //  Perímetro
        public double Perimeter()
        {
            return 3 * _side;
        }
    }
}
