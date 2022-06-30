using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwenty
    {
        public ExerciseTwenty()
        {
            int number = Tools.GetInt();
            int[] ints = new int[4];

            Console.WriteLine($"The product of {ints[0]}, {ints[1]} and {ints[2]} is {ints[3]}");

            for(int i = 0; i < 3; i++)
            {
                ints[i] = number;
                number--;
            }
        }

        private static void ExNineteenDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nUse a for-loop to calculate the product of the number and the two preceding numbers.");
        }
    }
}
