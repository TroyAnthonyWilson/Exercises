using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentyseven
    {
        public ExerciseTwentyseven()
        {
            Desc();
            do
            {
                Console.Write("Enter some text: ");
                string str = Console.ReadLine().Trim();

                var charsToRemove = new string[] { "a", "e", "i", "o", "u" };
                foreach(var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                Console.WriteLine($"There were {str.Length} consonants.");
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter text.  Count and output how many consonants are in the string.");
        }
    }
}
