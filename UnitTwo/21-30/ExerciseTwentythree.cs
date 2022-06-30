using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentythree
    {
        public ExerciseTwentythree()
        {
            Desc();
            do
            {
                Console.Write("Enter some text: ");
                string str = Console.ReadLine();
                Console.WriteLine($"The first 10 characters were: {str.Substring(0,10)}");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter a string.  Extract and output the first ten characters of the string.");
        }
    }
}
