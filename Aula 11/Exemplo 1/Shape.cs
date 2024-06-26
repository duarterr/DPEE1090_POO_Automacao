namespace Course
{
    abstract class Shape
    {
        protected int _numSides;

        public Shape(int numSides)
        {
            _numSides = numSides;
        }

        public int GetNumSides()
        {
            return _numSides;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
