using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtytwo
    {
        public ExerciseThirtytwo()
        {
            int[] intArray = new int[] { 2, 8, 0, 24, 51 };
            int input;
            Desc();

            do
            {
                input = Tools.GetInt();
            } while(IsInArray(input, intArray));
        }

        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51." +
                "\nPrompt the user to enter a number. If the number is in the array, display the index at which it is located.");
        }

        private static bool IsInArray(int index, int[] intArray)
        {
            if (Array.Find(intArray, element => element == index) == index)
            {
                Console.WriteLine(index);
            }
            return false;
        }
    }
}
