using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseSixteen
    {

        public ExerciseSixteen()
        {
            ExSixteenDesc();

            for(int i = 0; i <= 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void ExSixteenDesc()
        {
            Description.DescriptionCall("Use a for loop to output a triangle of asterisks with a height of ten.");
        }
    }
}
