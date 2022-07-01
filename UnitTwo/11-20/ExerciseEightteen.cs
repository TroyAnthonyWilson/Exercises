using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseEightteen
    {
        public ExerciseEightteen()
        {
            ExEightteenDesc();
            do
            {
                int number = Tools.GetInt(1);
                Console.WriteLine(Total(number)); 
            } while(Tools.IsYes());

        }

        private static int Total(int x)
        {
            int total = 0;
            for(int i = 0; i <= x; i++)
            {
                total += i;
            }
            return total;
        }

        private static void ExEightteenDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nUse a for-loop to calculate the sum of all the numbers from 1 to the number entered.");
        }
    }
}
