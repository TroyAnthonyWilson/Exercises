namespace Exercises
{
    internal class ExerciseFourtyFive
    {
        public ExerciseFourtyFive()
        {
            Desc();

            do
            {
                Square _ = new(Tools.GetDouble("Enter a side length: ", 0)); 
            } while(Tools.IsYes());

        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a class Square that has one property, SideLength." +
                "\nThe class should have two methods, CalculatePerimeter, and CalculateArea. " +
                "\nLet the user enter the length of the square's side. " +
                "\nCreate an object based on that length and output details of the square.");
        }
    }
}
