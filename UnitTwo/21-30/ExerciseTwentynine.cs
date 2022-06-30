using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentynine
    {
        public ExerciseTwentynine()
        {
            Desc();
            do
            {
                string str;
                string firstLetter;
                string laserLetter;
                do
                {
                    Console.Clear();
                    Console.Write("Enter some text: ");
                    str = Console.ReadLine().Trim(); 
                } while(str == string.Empty);

                string[] words = str.Split(' ');

                for(int i = 0; i < words.Length; i++)
                {
                    if(words[i].Length <= 2)
                    {
                        Console.WriteLine(words[i]);
                    }
                    else
                    {
                        string cut = words[i][1..^1];
                        var charsToRemove = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
                        foreach(var c in charsToRemove)
                        {
                            cut = cut.Replace(c, string.Empty);
                        }
                        Console.Write(words[i].Substring(0, 1) + cut + words[i].Substring(words[i].Length - 1) + " ");
                    } 
                }
                Console.WriteLine();
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter text." +
                "\nRemove all the vowels in the middle of the word, but leave any that start or end the word.");
        }
    }
}
