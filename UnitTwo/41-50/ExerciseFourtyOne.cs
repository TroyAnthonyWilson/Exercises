namespace Exercises
{
    internal class ExerciseFourtyOne
    {
        public ExerciseFourtyOne()
        {
            Desc();

            do
            {
                double[] doubleArray = new double[2];

                for(int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Tools.GetInt(0);
                }

                Console.WriteLine($"{doubleArray[0]}/{doubleArray[1]} is approximately {Math.Round(doubleArray[0] / doubleArray[1] , 2)}");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter two numbers.  Divide the two numbers and show only two decimal places.");
        }
    }
}
