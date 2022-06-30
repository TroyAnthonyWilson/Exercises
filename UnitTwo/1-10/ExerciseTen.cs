using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ExerciseTen
    {
        public ExerciseTen()
        {
            float height;
            const float minHeight = 54;
            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("Enter your height in inches: ");
                } while(!float.TryParse(Console.ReadLine(), out height) || height < 0 || height > 100);

                if(height < 54)
                {
                    Console.WriteLine($"Sorry, you cannot ride the Raptor.You need {minHeight - height} more inches.");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }

            } while(Tools.IsYes());
        }


        public static void ExTenDesc()
        {
            Description.DescriptionCall("Determine whether the user is tall enough to ride a roller coaster." +
                "\nPrompt the user to enter her height in inches." +
                "\nIf she is less than 54 inches tall, notify her that she cannot ride the Raptor." +
                "\nIf she is at least 54 inches tall, notify her that she can ride the Raptor.");
        }
    }
}
