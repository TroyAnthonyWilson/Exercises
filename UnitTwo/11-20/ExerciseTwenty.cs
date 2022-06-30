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
            Desc();

            do
            {
                int number = Tools.GetInt(2);
                int[] ints = new int[4];

                for(int i = 0; i < 3; i++)
                {
                    ints[i] = number;
                    number--;
                }
                ints[3] = ints[0] + ints[1] + ints[2];

                Console.WriteLine($"The product of {ints[0]}, {ints[1]} and {ints[2]} is {ints[3]}");


            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nUse a for-loop to calculate the product of the number and the two preceding numbers.");
        }
    }
}
