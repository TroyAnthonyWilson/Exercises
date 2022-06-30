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
                do
                {
                    input = Tools.GetInt(0);
                } while(IsInArray(input, intArray)); 
            } while(Tools.IsYes());
        }



        private static bool IsInArray(int numInIndex, int[] intArray)
        {
            if(Array.IndexOf(intArray, numInIndex) != -1)
            {
                Console.WriteLine($"The value {numInIndex} can be found at index {Array.IndexOf(intArray, numInIndex)}");
                return false;
            }
            else
            {
                Console.WriteLine("That value cannot be found in the array.");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                return true;
            }
        }
        
        
        
        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51." +
                "\nPrompt the user to enter a number. If the number is in the array, display the numInIndex at which it is located.");
        }
    }
}
