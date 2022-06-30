using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentysix
    {
        public ExerciseTwentysix()
        {
            Desc();
            do
            {
                Console.Write("Enter some text: ");
                string str = Console.ReadLine();
                int count = str.Count(f => f == 'a');
                count += str.Count(f => f == 'e');
                count += str.Count(f => f == 'i');
                count += str.Count(f => f == 'o');
                count += str.Count(f => f == 'u');
                Console.WriteLine($"There were {count} vowels.");

            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter text.\nCount and output how many vowels are in the string.");
        }
    }
}
