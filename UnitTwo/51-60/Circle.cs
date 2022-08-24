namespace Exercises
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;

            Console.WriteLine($"You entered a radius of: {Radius}");
            Console.WriteLine($"Circumference: {CalculatePerimeter()}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }


        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        /// <summary>
        /// Calculates circle circumference
        /// </summary>
        /// <returns>The circumference of the circle</returns>
        public override double CalculatePerimeter()
        {
            _perimeter = Radius * 2 * Math.PI;
            return Perimeter;
        }

        /// <summary>
        /// Calculates the circles area
        /// </summary>
        /// <returns>The area of the circle</returns>
        public override double CalculateArea()
        {
            _area = Radius * Radius * Math.PI;
            return Area;
        }

     
    }
}
