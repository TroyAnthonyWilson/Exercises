using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirty
    {
        public ExerciseThirty()
        {
            Desc();
            do
            {
                string str;
                do
                {
                    Console.Write("Enter some text: ");
                    str = Console.ReadLine();
                } while(str == string.Empty);
                char[] strArray = str.ToCharArray();

                Array.Reverse(strArray);

                foreach(char c in strArray)
                {
                    Console.Write(c);
                }
                Console.WriteLine(); 
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter text.  Reverse the text.");
        }
    }
}
