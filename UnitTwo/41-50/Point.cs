namespace Exercises
{
    internal class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public static double CalculateDistance(Point point)
        {
            return Math.Sqrt((Math.Pow(point.x, 2) + Math.Pow(point.y, 2)));
        }

        public static Point CalculateMidpoint(Point point1 , Point point2)
        {
            Point midpoint = new Point()
            {
                x = (point1.x + point2.x) / 2,
                y = (point1.y + point2.y) / 2,
            };
            return midpoint;
        }

    }
}
