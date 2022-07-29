namespace Exercises
{
    internal class ExerciseFourtyNine
    {
        public ExerciseFourtyNine()
        {
            Desc();

            bool iscontinue;
            List<Square> list = new();

            do
            {

                double userInput = Tools.GetDouble("Enter a side length (q to quit): ", 0, out iscontinue);

                if(iscontinue)
                {
                    Square _ = new(userInput);
                    list.Add(_);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }

                Console.WriteLine($"Largest area : {list.Max(s => s.Area)}");
                Console.WriteLine($"Smallest area: {list.Min(s => s.Area)}");
                Console.WriteLine($"Average area : {list.Average(s => s.Area)}");
                Console.WriteLine($"Average perimeter: {list.Average(s => s.Perimeter)}");



            } while(iscontinue);
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a Square class and a list of squares." +
                "\nThen display some statistics for the collection of squares.");
        }
    }
}
