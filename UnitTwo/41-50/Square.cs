
namespace Exercises
{
    internal class Square : Shape
    {
        private double _sideLength;

        public Square(double sideLenght)
        {
            _sideLength = sideLenght;
            _perimeter = CalculatePerimeter();
            _area = CalculateArea();
            Console.WriteLine($"The square has side length {_sideLength}.  Its area is {_area} and its perimeter is {_perimeter}.");
        }




        public override double CalculatePerimeter()
        {
            return _sideLength * 4;
        }

        public override double CalculateArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
