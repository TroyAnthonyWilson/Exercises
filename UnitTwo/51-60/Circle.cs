namespace Exercises
{
    public class Circle
    {
        private double _radius;
        private double _area;
        private double _circumference;

        public Circle(double radius)
        {
            Radius = radius;

            Console.WriteLine($"You entered a radius of: {Radius}");
            Console.WriteLine($"Circumference: {CalculateCircumference()}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }


        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public double Circumference 
        {
            get { return _circumference; }
            set { _circumference = value; }
        }

        /// <summary>
        /// Caculates circle circumference
        /// </summary>
        /// <returns>The circumference of the circle</returns>
        public double CalculateCircumference()
        {
            Circumference = Radius * 2 * Math.PI;
            return Circumference;
        }

        /// <summary>
        /// Caculates the circles area
        /// </summary>
        /// <returns>The area of the circle</returns>
        public double CalculateArea()
        {
            Area = Radius * Radius * Math.PI;
            return Area;
        }

     
    }
}
