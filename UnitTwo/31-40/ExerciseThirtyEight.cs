namespace Exercises
{
    internal class ExerciseThirtyEight
    {
        public ExerciseThirtyEight()
        {
            Desc();
            do
            {

                int[] intArray = new int[5];

                for(int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = Tools.GetInt(-0);
                }

                for(int i = 0; i < intArray.Length; i++)
                {
                    Console.Write($"{intArray[i]}");
                    if(i < intArray.Length - 1)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine($" / {intArray.Length} = {intArray.Average()}");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter five numbers.  Store these numbers in an array and output their average.");
        }
    }
}
