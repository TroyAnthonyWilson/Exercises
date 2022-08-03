namespace Exercises
{
    internal class ExerciseFiftyTwo
    {
        public ExerciseFiftyTwo()
        {
            Desc();
            List<Triangle> triangles = new();
            List<Circle> circles = new();

            bool isContinue = true;
            do
            {
                Console.WriteLine("Enter a new shape.  Square (1), Triangle (2), Circle(3), Quit(q): ");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch(userInput)
                {
                    case "1":
                        break;
                    case "2":
                        double[] sides = Tools.GetDoubleArray("Enter in side", 0, 3);
                        triangles.Add(new Triangle(sides));
                        break;
                    case "3":
                        break;
                    case "q":
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while(isContinue);
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter data for a collection of shapes." +
                "\nDisplay aggregate information about the shapes.");
        }
    }
}
