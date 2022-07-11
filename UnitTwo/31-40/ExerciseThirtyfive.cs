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
            string[] animals = new string[] { "cow", "elephant", "jaguar", "horse", "crow" };

            do
            {
                Console.Write("Enter two indices separated by a space: ");
                string input = Console.ReadLine().ToLower().Trim();

                char ch = ' ';
                string[] stringArray = input.Split(ch);
                int[] intArray = new int[stringArray.Length];
                bool isGood = true;

                if(input.Count(f => (f == ch)) == 1)
                {
                    for(int i = 0; i < stringArray.Length; i++)
                    {
                        int outPut;
                        try
                        {
                            outPut = int.Parse(stringArray[i]);
                            if(i == 0 && outPut <= 4)
                            {
                                intArray[i] = outPut;
                            }
                            else if(i == 1 && outPut < animals[intArray[0]].Length)
                            {
                                intArray[i] = outPut;
                            }
                            else
                            {
                                Console.WriteLine("That is not a valid index.");
                                isGood = false;
                            }
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Sorry you entered something that wasn't a number.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            break;
                        }

                    }
                    if(isGood)
                    {
                        Console.WriteLine($"The value at index {intArray[0]} is {animals[intArray[0]]}. The letter at index {intArray[1]} is {animals[intArray[0]].ElementAt(intArray[1])}.");
                    }

                }
                else Console.WriteLine("It dosn't lool like you folowed the instructions");
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
