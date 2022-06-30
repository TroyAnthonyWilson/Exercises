using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseOneSeven
    {
        public ExerciseOneSeven()
        {
            ExOneSevenDesc();

            bool answer;

            do
            {
                Console.Clear();
                Console.Write("Enter a boolean: ");
            } while(!Boolean.TryParse(Console.ReadLine().Trim() ,out answer));
            
            
            if(answer)
            {
                Console.WriteLine("You entered: True");
                opp(false);
            }
            else
            {
                Console.WriteLine("You entered: False");
                opp(true);
            }

            static void opp(bool opp)
            {
                Console.WriteLine($"The opposite of what you entered is : {opp}");
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        private static void ExOneSevenDesc()
        {
            Description.DescriptionCall("Prompt the user to enter a boolean. Write out the boolean value, and then write out the opposite of the boolean variable.");
        }
    }
}


