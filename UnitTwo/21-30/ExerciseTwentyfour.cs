using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentyfour
    {
        public ExerciseTwentyfour()
        {
            Desc();
            do
            {
                Console.Write("Enter some text: ");
                string str = Console.ReadLine();
                Console.WriteLine($"The last ten characters were: {str.Substring(Math.Max(0,str.Length -10))}");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter a string.  Extract and output the last ten characters of the string.");
        }
    }
}
