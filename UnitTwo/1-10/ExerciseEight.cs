using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseEight
    {
        public ExerciseEight()
        {
            string response;
            ExEightDesc();
            Console.WriteLine("2 : Add 1 to the number and output it back to the console.");
            Console.WriteLine("\n3 : Add .5 to the number and output it back to the console.");
            Console.WriteLine("\n4 : Add them together and output the sum back to the console.");
            Console.WriteLine("\n5 : Multiply them and output the product back to the console.");
            Console.Write("\nPlease choose an exercise to Loop: ");
            response = Console.ReadLine();


            switch(response)
            {
                case "2":                   
                    do
                    {
                        _ = new ExerciseTwo();
                    } while(Tools.IsYes());
                    break;
                case "3":
                    do
                    {
                        _ = new ExerciseThree();
                    } while(Tools.IsYes());
                    break;
                case "4":
                    do
                    {
                        _ = new ExerciseFour();
                    } while(Tools.IsYes());
                    break;
                case "5":
                    do
                    {
                        _ = new ExerciseFive();
                    } while(Tools.IsYes()); ;
                    break;
                default:
                    _ = new ExerciseEight();
                    break; 
            }
        }


        private static void ExEightDesc()
        {
            Description.DescriptionCall("Make exercises 2-5 run in a Loop. Use a do-while Loop to run the code in a Loop.\n" +
                "Each time you run the code ask the user whether they would like to continue.");
        }
    }
}
