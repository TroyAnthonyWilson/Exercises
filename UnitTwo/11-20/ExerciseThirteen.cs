using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseThirteen
    {


        public ExerciseThirteen()
        {
            ExThirteenDesc();
            do
            {
                int number = Tools.GetInt();

                for(int i = number; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }


            } while(Tools.IsYes());
        }

        private static void ExThirteenDesc()
        {
            Description.DescriptionCall("Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.");
        }
    }
}
