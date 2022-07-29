namespace Exercises
{
    internal class ExerciseFourtySix
    {
        public ExerciseFourtySix()
        {
            Desc();

            do
            {
                double[] sides = Tools.GetDoubleArray("Enter in side", 0, 3);
                Triangle _ = new(sides);
            } while(Tools.IsYes());
        }

    private static void Desc()
    {
        Description.DescriptionCall("Create a class Triangle, that has three properties, Side1Length, Side2Length, Side3Length" +
            "\nThe class should have two methods, CalculatePerimeter, and CalculateArea. Let the user enter the length of the triangle's sides." +
            "\nCreate an object based on those lengths and output the triangle's details. Hint: Google Heron's Formula.");
    }
}
}
