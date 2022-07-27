using System.Windows;

namespace Exercises
{
    internal class ExerciseFourtyThree
    {
        public ExerciseFourtyThree()
        {

            Desc();
            do
            {             
                Point point = new()
                {
                    x = Tools.GetInt("Enter an X coordinate: "),
                    y = Tools.GetInt("Enter an Y coordinate: ")
                };
                Console.WriteLine($"You have created a point object ({point.x},{point.y}) if has a distance of {Point.CalculateDistance(point)}.");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Enhance the point class in the previous exercise by adding a CalculateDistance method.\n" +
                "The distance method will calculate the distance of a point from the origin, (0,0).  ");
        }
    }


}
