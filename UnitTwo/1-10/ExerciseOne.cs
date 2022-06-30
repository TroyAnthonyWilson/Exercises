using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseOne
    {
        public ExerciseOne()
        {
            ExOneDesc();
            Console.Write("Enter some text:");
            Console.WriteLine(Console.ReadLine());
        }

        private static void ExOneDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a string.\nAfter the user enters a string, output the same string back to the console.");
        }
    }
}
