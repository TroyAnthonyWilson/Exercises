using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtysix
    {
        public ExerciseThirtysix()
        {
            Desc();
            int[] intArray = { 12, 11, 10, 9, 8 };
            string[] strArray = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking"};

            do
            {
                Console.Write("Enter a command (sing/quit): ");
                string userInput = Console.ReadLine().ToLower().Trim();
                if("sing".StartsWith(userInput))
                {
                    Console.Clear();
                    for(int i = 0; i < intArray.Length; i++)
                    {
                        Console.WriteLine($"{intArray[i]} {strArray[i]}");
                    }
                }
                else if("quit".StartsWith(userInput))
                {
                    return;
                }
            } while(true);

        }

        private static void Desc()
        {
            Description.DescriptionCall("Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. " +
                "\nFill the second array with the strings: \"Drummers Drumming\", \"Pipers Piping\", \"Lords a - Leaping\", \"Ladies Dancing\", \"Maids a - Milking\". " +
                "\nCombine both arrays to display a piece of the holiday song.");
        }
    }
}
