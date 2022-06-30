using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseFour
    {
        public ExerciseFour()
        {
            ExFourDesc();
            float numberOne = Tools.GetFloat("Please enter the first number: ");
            float numberTwo = Tools.GetFloat("Please enter the second number: ");
            Console.WriteLine($"The sum is {numberOne + numberTwo}");
        }

        private static void ExFourDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nAfter the user enters the numbers, add them together and output the sum back to the console.");
        }
    }
}
