using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseSix
    {
        public ExerciseSix()
        {
            ExSixDesc();
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, World!");
            } while(Tools.IsYes());
        }

        private static void ExSixDesc()
        {
            Description.DescriptionCall("Use a do-while Loop to output \"Hello, World!\" in a Loop.\nEach time you output" +
                " \"Hello, World!\" ask the user whether they would like to continue.");
        }
    }
}
