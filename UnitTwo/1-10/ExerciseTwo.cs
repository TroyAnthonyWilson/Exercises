using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwo
    {
        public ExerciseTwo()
        {
            ExTwoDesc();
            int x = Tools.GetInt();
            Console.WriteLine(++x);
        }

        private static void ExTwoDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a number.\nAfter the user enters a number, add 1 to the number and output it back to the console.");
        }
    }
}
