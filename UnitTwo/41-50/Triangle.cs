﻿namespace Exercises
{
    internal class Triangle
    {
        private readonly double _side1Length;
        private readonly double _side2Length;
        private readonly double _side3Length;
        private double _area;
        private double _perimeter;

        public Triangle(double[] sideLength)
        {
            _side1Length = sideLength[0];
            _side2Length = sideLength[1];
            _side3Length = sideLength[2];

            if(_side1Length + _side2Length == _side3Length || _side1Length + _side3Length == _side2Length || _side2Length + _side3Length == _side1Length)
            {
                Console.WriteLine("Not a valid triangle.");
                return;
            }

            Console.WriteLine($"The triangle has side lengths {_side1Length}, {_side2Length}, and {_side3Length}.Its area is {CaculateArea()} and its perimeter is {CalculatePerimeter()}.");
        }

        public double Area
        {
            get { return _area; }
        }

        public double Perimeter
        {
            get { return _perimeter; }
        }

        public double CalculatePerimeter()
        {
            _perimeter = _side1Length + _side2Length + _side3Length;
            return _perimeter;
        }

        public double CaculateArea()
        {
            double s = (_side1Length + _side2Length + _side3Length) / 2;
            _area = Math.Sqrt(s * (s - _side1Length) * (s - _side2Length) * (s - _side3Length));
            return _area;
        }
    }
}
