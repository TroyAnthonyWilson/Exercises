
namespace Exercises
{
    internal class Square
    {
        private double _sideLength;
        private double _perimeter;
        private double _area;

        public Square(double sideLenght)
        {
            _sideLength = sideLenght;
            _perimeter = CalculatePerimeter();
            _area = CalculateArea();
            Console.WriteLine($"The square has side length {_sideLength}.  Its area is {_area} and its perimeter is {_perimeter}.");
        }

        public double Area 
        {
            get { return _area; }
        }

        public double Perimeter
        {
            get { return _perimeter; }
        }

        private double CalculatePerimeter()
        {
            return _sideLength * 4;
        }

        private double CalculateArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
