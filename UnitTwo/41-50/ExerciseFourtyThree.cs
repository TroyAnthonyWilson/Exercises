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

                double distance = Math.Sqrt((Math.Pow(point.x, 2) + Math.Pow(point.y, 2)));

                Console.WriteLine($"You have created a point object ({point.x},{point.y}) if has a distance of {distance}.");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a class called Point, that has two properties, X and Y.\n" +
                "Let the user enter an X and Y value to create a Point object.");
        }
    }


}
