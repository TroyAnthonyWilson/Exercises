namespace Exercises
{
    internal class ExerciseFourtySeven
    {
        public ExerciseFourtySeven()
        {
            Desc();
            List<string> words = new();
            do
            {
                words.Add(Tools.GetWord("Please enter a word to add: "));
                foreach(var item in words)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Repeatedly prompt the user to enter a string." +
                "\nStore the string in a list and display the contents of the list with each element separated by a space.");
        }
    }
}
