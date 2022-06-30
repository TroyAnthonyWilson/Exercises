using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwentytwo
    {
        public ExerciseTwentytwo()
        {
            Desc();
            do
            {
                do
                {
                    int x = Tools.GetInt("Enter the first number: ");
                    int y = Tools.GetInt("Enter the second number: ");
                    if(x < y)
                    {
                        Console.WriteLine($"{x} is smaller then {y}");
                    }else
                    {
                        int z = y;
                        y = x;
                        x = z;
                        Console.WriteLine($"{x} is smaller then {y}");
                    }
                    int i = Tools.GetInt("Enter a number to verify it is in the range: ");

                    if(i > x && i < y)
                    {
                        Console.WriteLine($"{i} is in the range.");
                    }

                } while(Tools.IsYes("Would you like to check another number y/n? "));
            } while(Tools.IsYes());
        }

        private static void Desc()
        {
            Description.DescriptionCall("Prompt the user to enter two numbers that will determine a range.\n" +
                "Then prompt the user to enter another number and check if it is in the range.");
        }
    }
}
