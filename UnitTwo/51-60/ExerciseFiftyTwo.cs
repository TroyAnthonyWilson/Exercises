namespace Exercises
{
    internal class ExerciseFiftyTwo
    {
        public ExerciseFiftyTwo()
        {
            Desc();
            List<Shape> shapes = new();

            bool isContinue = true;
            do
            {
                Console.WriteLine("Enter a new shape.  Square (1), Triangle (2), Circle(3), Quit(q): ");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch(userInput)
                {
                    case "1":
                        double side = Tools.GetDouble("Enter length of square side: ", 0);
                        Shape newSquare = new Square(side);
                        if(newSquare.Area > 0)
                        {
                            shapes.Add(newSquare);
                        }
                        break;
                    case "2":
                        double[] sides = Tools.GetDoubleArray("Enter length of side", 0, 3);
                        Shape newTriangle = new Triangle(sides);
                        if(newTriangle.Area > 0)
                        {
                            shapes.Add(newTriangle);
                        }
                        break;
                    case "3":
                        double radius = Tools.GetDouble("Enter radius of circle: ", 0);
                        Shape newCircle = new Circle(radius);
                        if(newCircle.Area > 0)
                        {
                            shapes.Add(newCircle);
                        }
                        break;
                    case "q":
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                try
                {
                    Console.WriteLine($"\nAverage area {shapes.Average(x => x.Area)}" +
                         $"\nAverage perimeter {shapes.Average(x => x.Perimeter)}" +
                         $"\nTotal number of shapes {shapes.Count}" +
                         $"\nPress any key to continue...");
                }
                catch(Exception)
                {
                    Console.WriteLine("No shapes have been added." +
                        "\nPress any key to continue...");
                }
                Console.ReadKey();
                Console.Clear();
            } while(isContinue);

        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter data for a collection of shapes." +
                "\nDisplay aggregate information about the shapes.");
        }
    }
}
