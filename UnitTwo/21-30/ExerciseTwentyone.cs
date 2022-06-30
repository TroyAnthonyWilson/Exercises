using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentyone
    {
        public ExerciseTwentyone()
        {
            Desc();
            do
            {
                string sentence = " ";
                do
                {
                    Console.Write("Enter a word: ");
                    sentence = sentence + " " + Console.ReadLine().Trim();
                } while(Tools.IsYes("Would you like to enter another word Y/N? "));
                Console.WriteLine(sentence.Trim()); 
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter a series of words." +
                "\nOnce the user is done entering the words, output a sentence containing all the words.");
        }
    }


}
