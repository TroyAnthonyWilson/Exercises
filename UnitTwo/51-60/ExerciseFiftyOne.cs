namespace Exercises
{
    internal class ExerciseFiftyOne
    {
        public ExerciseFiftyOne()
        {
            Desc();
            Dictionary<string, string> translation = new()
            {
                {"hello","hola"},
                {"food","comida"},
                {"world","mundo"},
                {"computer","computadora"},
                {"exercise","ejercicio"},
            };

            do
            {
                Console.Write("Enter a word in English: ");
                string userInput = Console.ReadLine().ToLower().Trim();
                if(translation.TryGetValue(userInput, out string value))
                {
                    Console.WriteLine($"World in Spanish is {value}");
                    continue;
                }
                Console.WriteLine("I did not find that word");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create a dictionary with the following key value pairs: " +
                "\nhello => hola, food => comida, world => mundo, computer => computadora, exercise => ejercicio.  " +
                "\nPrompt the user to enter a word and output the translation.");
        }
    }
}
