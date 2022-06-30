using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtythree
    {
        public ExerciseThirtythree()
        {
            int[] intArray = new int[] { 2, 8, 0, 24, 51 };
            int input;
            Desc();

            do
            {
                input = Tools.GetInt(0);
                if(input > intArray.Length)
                {
                    Console.WriteLine("That is not a valid index.");
                }
                else
                {
                    Console.WriteLine($"The value at index {input} is {intArray[input]}.");
                    if(Tools.IsYes("Would you like to change it Y/N ?"))
                    {
                        intArray[input] = Tools.GetInt("Enter the new value at index 2: ");
                        Console.WriteLine($"The value at index {input} is {intArray[input]}.");
                    }
                }
            } while(Tools.IsYes());

        }

        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. " +
                "\nLet the user change the array by specifying an index and a replacement number.");
        }
    }
}
