namespace Exercises
{
    internal class ExerciseFourtyFour
    {
        public ExerciseFourtyFour()
        {
            Desc();
            do
            {
                Point point1 = new()
                {
                    x = Tools.GetInt("Enter an X coordinate for the first point: "),
                    y = Tools.GetInt("Enter an Y coordinate for the first point: ")
                };
                Point point2 = new()
                {
                    x = Tools.GetInt("Enter an X coordinate for the second point: "),
                    y = Tools.GetInt("Enter an Y coordinate for the second point: ")
                };
                Point midpoint = Point.CalculateMidpoint(point1, point2);

                Console.WriteLine($"The midpoint between ({point1.x},{point1.y}) and ({point2.x},{point2.y}) is ({midpoint.x},{midpoint.y}).");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Enhance the point class in the previous exercise by adding a CalculateMidpoint method./n" +
                "The CalculateMidpoint will take as an argument another point instance\n" +
                "and return the midpoint between the current ('this') object and the point passed in.\n" +
                "Its method signature will look like: Point CalculateMidpoint(Point other) ");
        }
    }
}
