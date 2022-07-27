namespace Exercises
{
    internal class ExerciseFourty
    {
        public ExerciseFourty()
        {
            Desc();
            do
            {
                int[] intArray = new int[5];

                for(int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = Tools.GetInt(0);
                }

                intArray = intArray.OrderBy(x => x).ToArray();

                Console.Write("The median of (");
                intArray.OrderBy(x => x).ToList().ForEach(x => Console.Write($"{x} "));
                Console.WriteLine($") is {intArray[2]}");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter five numbers.  Store these numbers in an array and output the median.");
        }
    }
}
