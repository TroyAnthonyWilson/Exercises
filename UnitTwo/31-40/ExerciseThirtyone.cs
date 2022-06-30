using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtyone
    {
        public ExerciseThirtyone()
        {
            Desc();
            do
            {
                int[] intArray = new int[] { 2, 8, 0, 24, 51 };
                int intArrayIndex;
                do
                {
                    intArrayIndex = Tools.GetInt("Enter the index of the array: ");
                    if(intArrayIndex > intArray.Length)
                    {
                        Console.WriteLine("That is not a valid index.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                } while(intArrayIndex > intArray.Length);

                Console.WriteLine(intArray[intArrayIndex]); 
            } while(Tools.IsYes());

        }

        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51." +
                "\nPrompt the user to enter an index. Display the element in the array at that index.");
        }
    }
}
