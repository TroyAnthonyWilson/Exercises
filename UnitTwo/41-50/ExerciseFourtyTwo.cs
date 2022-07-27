namespace Exercises
{
    internal class ExerciseFourtyTwo
    {
        public ExerciseFourtyTwo()
        {
            Desc();
            do
            {
                Point point = new();
                point.x = Tools.GetInt("Enter an X coordinate: ");
                point.y = Tools.GetInt("Enter an Y coordinate: ");

                Console.WriteLine($"You have created a point object ({point.x},{point.y})");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a class called Point, that has two properties, X and Y.\n" +
                "Let the user enter an X and Y value to create a Point object.");
        }
    }


}
