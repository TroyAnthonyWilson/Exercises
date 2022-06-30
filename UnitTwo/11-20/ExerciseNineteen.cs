using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseNineteen
    {
        public ExerciseNineteen()
        {
            ExNineteenDesc();
            do
            {
                int x;
                int y;
                do
                {
                    x = Tools.GetInt("Enter the first number: ");
                    y = Tools.GetInt("Enter the second number: ");
                    if(x > y)
                    {
                        Console.WriteLine("The first number must be smaller then the second number");
                        Console.WriteLine("Press any Key to continue");
                        Console.ReadKey();
                    }
                } while(x > y);

                Console.WriteLine($"The sume of all the number from {x} to {y} is {Total(x, y)}");

            } while(Tools.IsYes());
        }

        private static int Total(int x, int y)
        {
            int total = 0;
            for(int i = x; i <= y; i++)
            {
                total += i;
            }
            return total;
        }

        private static void ExNineteenDesc()
        {
            Description.DescriptionCall("Prompt the user to enter two numbers.\nUse a for-loop to calculate the sum of all the numbers from the first number entered to the second.");
        }
    }
}
