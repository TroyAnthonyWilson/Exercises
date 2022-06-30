using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseOneSix
    {

        public ExerciseOneSix()
        {
            ExOneSixDesc();
            int diviOne = Tools.GetInt("Please enter the first number: ");
            int diviTwo = Tools.GetInt("Please enter the second number: ");
            Console.WriteLine($"The result is {diviOne / diviTwo}");
        }

        private static void ExOneSixDesc()
        {
            Description.DescriptionCall("Prompt the user to enter two numbers.\nAfter the user enters the numbers," +
                " divide them and output the result back to the console." +
                "\nNotice what happens when you enter two numbers that don’t divide evenly.\nWhat number do you get?" +
                "\nTry running the program by entering decimal numbers.\nWhat happens?");
        }
    }
}
