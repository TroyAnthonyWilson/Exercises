using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseNine
    {
        public ExerciseNine()
        {
            ExNineDesc();
            string response;
            do
            {
                Console.WriteLine("Languages: English, Spanish, Dutch");
                Console.Write("Enter a language: ");
                response = Console.ReadLine().ToLower().Trim();

                switch(response)
                {
                    case "english":
                        Console.WriteLine("Hello, World!");
                        break;
                    case "spanish":
                        Console.WriteLine("Hola Mundo!");
                        break;
                    case "dutch":
                        Console.WriteLine("Hallo wereld!");
                        break;
                    default:
                        Console.WriteLine("Invalid response");
                        break;
                }
            } while(Tools.IsYes());
        }

        private static void ExNineDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a language." +
                "\nBased on the language the user input, display \"Hello, World!\" in that language. " +
                "\nUse a switch statement to choose what to display.");
        }
    }
}
