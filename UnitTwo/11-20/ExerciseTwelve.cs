using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTwelve
    {
        public ExerciseTwelve()
        {
            ExTwelveDesc();
            do
            {
                Console.Clear();
                for(int i = 9; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
            } while(Tools.IsYes());
        }

        private static void ExTwelveDesc()
        {
            Description.DescriptionCall("Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.");
        }
    }
}
