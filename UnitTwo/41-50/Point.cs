namespace Exercises
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public static double CalculateDistance(Point point)
        {
            return Math.Sqrt((Math.Pow(point.x, 2) + Math.Pow(point.y, 2)));
        }

    }
}
