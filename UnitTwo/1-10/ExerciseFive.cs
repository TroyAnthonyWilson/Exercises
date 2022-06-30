using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseFive
    {
        public ExerciseFive()
        {
            ExFiveDesc();
            float multOne = Tools.GetFloat("Please enter the first number: ");
            float multTwo = Tools.GetFloat("Please enter the second number: ");
            Console.WriteLine($"The product is {multOne * multTwo}");
        }

        private static void ExFiveDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nAfter the user enters the numbers, multiply them and output the product back to the console.");
        }
    }
}
