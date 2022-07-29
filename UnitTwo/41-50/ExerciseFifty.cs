namespace Exercises
{
    internal class ExerciseFifty
    {

        public ExerciseFifty()
        {
            Desc();
            bool iscontinue;
            List<Triangle> list = new();

            do
            {

                double[] userInput = Tools.GetDoubleArray("Enter a side length  ", 0, 3 ,  out iscontinue);

                if(iscontinue)
                {
                    Triangle _ = new(userInput);
                    list.Add(_);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"Largest area : {list.Max(s => s.Area)}");
                Console.WriteLine($"Smallest area: {list.Min(s => s.Area)}");
                Console.WriteLine($"Average area : {list.Average(s => s.Area)}");
                Console.WriteLine($"Average perimeter: {list.Average(s => s.Perimeter)}");

            } while(iscontinue);
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a triangle class and a list of triangles. " +
                "\nThen display some statistics for the collection of Triangles.");
        }
    }
}
