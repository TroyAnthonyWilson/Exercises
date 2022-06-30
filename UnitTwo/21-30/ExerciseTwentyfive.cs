using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentyfive
    {
        public ExerciseTwentyfive()
        {
            Desc();
            do
            {
                Console.Write("Please enter a sentence: ");
                string str = Console.ReadLine();
                string[] words = str.Split(' ');

                foreach(string item in words)
                {
                    Console.WriteLine(item);
                } 
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter a sentence.\nSplit the sentence into individual words and display each word on its own line.");
        }
    }
}
