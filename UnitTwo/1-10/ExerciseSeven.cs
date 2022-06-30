using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseSeven
    {
        public ExerciseSeven()
        {
            ExSevenDesc();
            do
            {
                Console.Clear();
                _ = new ExerciseOne();
            } while(Tools.IsYes());
        }

        private static void ExSevenDesc()
        {
            Description.DescriptionCall("Use a do-while Loop to run exercise 1 in a Loop." +
                "\nEach time you run the code ask the user whether they would like to continue.");
        }

    }
}
