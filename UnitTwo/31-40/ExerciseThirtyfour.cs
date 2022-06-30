using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtyfour
    {
        public ExerciseThirtyfour()
        {
            Desc();
            int[] intArray = new int[] { 16, 32, 64, 128, 256 };
            do
            {
                Console.Write("Enter a command (half/double): ");
                string input = Console.ReadLine().ToLower().Trim();

                if(input == "half")
                {
                    Console.Write("The array now contains: ");
                    for(int i = 0; i < intArray.Length; i++)
                    { 
                        Console.Write((intArray[i] /= 2) + " ");
                    }
                }
                else if (input == "double")
                {
                    Console.Write("The array now contains: ");
                    for(int i = 0; i < intArray.Length; i++)
                    {
                        Console.Write((intArray[i] *= 2) + " ");
                    }
                }
                Console.WriteLine();

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256." +
                "\nPrompt the user to enter a command, 'half' or 'double'." +
                "\nIf the user enters 'half', half all the elements in the array." +
                "\nIf the user enters 'double', double all the elements in the array.");
        }
    }
}
