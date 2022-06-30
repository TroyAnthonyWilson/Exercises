using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseFifteen
    {
        public ExerciseFifteen()
        {
            ExFifteenDesc();
            int number = Tools.GetInt();
            for(int i = 1; i <= number; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
            Console.WriteLine();
        }

        private static void ExFifteenDesc()
        {
            Description.DescriptionCall("Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to that number.");
        }
    }
}
