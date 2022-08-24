namespace Exercises
{
    internal class Triangle : Shape
    {
        private readonly double _side1Length;
        private readonly double _side2Length;
        private readonly double _side3Length;

        public Triangle(double[] sideLength)
        {
            _side1Length = sideLength[0];
            _side2Length = sideLength[1];
            _side3Length = sideLength[2];

            if((_side1Length + _side2Length > _side3Length) && (_side1Length + _side3Length > _side2Length) && (_side2Length + _side3Length > _side1Length))
            {
                Console.WriteLine($"The triangle has side lengths {_side1Length}, {_side2Length}, and {_side3Length}.Its area is {CalculateArea()} and its perimeter is {CalculatePerimeter()}.");
            }
            else
            {
                Console.WriteLine("Not a valid triangle.");
            }
        }



        public override double CalculatePerimeter()
        {
            _perimeter = _side1Length + _side2Length + _side3Length;
            return _perimeter;
        }

        public override double CalculateArea()
        {
            double s = (_side1Length + _side2Length + _side3Length) / 2;
            _area = Math.Sqrt(s * (s - _side1Length) * (s - _side2Length) * (s - _side3Length));
            return _area;
        }
    }
}
