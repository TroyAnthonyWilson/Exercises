using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirtyfive
    {
        public ExerciseThirtyfive()
        {
            Desc();
            string[] stringArray = new string[] { "cow", "elephant", "jaguar", "horse", "crow" };

            do
            {
                Console.Write("Enter two indices separated by a space: ");
                string input = Console.ReadLine().ToLower().Trim();


                Console.WriteLine();

            } while(Tools.IsYes()); 

        }

        private static void Desc()
        {
            Description.DescriptionCall("Create an array of size 5 and fill it with the following strings:\"cow\", \"elephant\", \"jaguar\", \"horse\", \"crow\"." +
                "\nPrompt the user to enter two indices separated by a space." +
                "\nThe first index will specify the word, and the second will specify a letter in that word." +
                "\nDisplay the corresponding word and letter.");
        }
    }
}
