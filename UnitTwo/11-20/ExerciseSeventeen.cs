using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseSeventeen
    {

        public ExerciseSeventeen()
        {
            ExSeventeenDesc();
            int height = 10;
            int loops = height;
            int width = 1;

            for(int i = 0; i < loops; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < width; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                height--;
                width++; 
            }

            Console.ReadKey();
        }

        private static void ExSeventeenDesc()
        {
            Description.DescriptionCall("Use a for loop to output a triangle of asterisks with a height of ten.");
        }
    }
}
