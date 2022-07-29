namespace Exercises
{
    internal class ExerciseFourtyEight
    {
        public ExerciseFourtyEight()
        {
            Desc();

            List<int> intList = new();

            do
            {
                bool isContinue;
                do
                {
                    int userInput = Tools.GetInt("Please enter a number or q to quit: ", out isContinue);
                    if(isContinue)
                    {
                        intList.Add(userInput); 
                    } 
                } while(isContinue);



                for(int i = 0; i < intList.Count; i++)
                {
                    Console.Write(intList[i]);
                    if(i < intList.Count - 1)
                    {
                        Console.Write(" + ");
                        continue;
                    }
                    Console.WriteLine($" = {intList.Sum()}");
                }
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter as many numbers as she wants." +
                "\nStore these numbers in a list and output their sum.");
        }
    }
}
