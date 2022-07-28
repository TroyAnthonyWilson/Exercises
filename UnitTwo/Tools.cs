namespace Exercises
{
    internal class Tools
    {
        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <returns>Positive int</returns>
        public static int GetInt()
        {
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
                if(int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.Clear();
                    return x;
                }
                Console.WriteLine("Sorry that is not a valid number");
                Thread.Sleep(2000);
                Console.Clear();
            } while(true);
        }

        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <returns>Positive int</returns>
        public static int GetInt(int low)
        {
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
                if(int.TryParse(Console.ReadLine(), out int x) && x >= low)
                {
                    Console.Clear();
                    return x;
                }
                Console.WriteLine("Sorry that is not a valid number");
                Thread.Sleep(2000);
                Console.Clear();
            } while(true);
        }

        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <param name="discription">Input custom number request</param>
        /// <returns>Positive int</returns>
        public static int GetInt(string discription)
        {
            do
            {
                Console.Clear();
                Console.Write(discription);
                if(int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.Clear();
                    return x;
                }
                Console.WriteLine("Sorry that is not a valid number");
                Thread.Sleep(2000);
                Console.Clear();
            } while(true);
        }

        /// <summary>
        /// Gets a int form the user
        /// </summary>
        /// <param name="discription">Input custom number request</param>
        /// <returns>Positive int</returns>
        public static int GetInt(string discription, int low)
        {
            do
            {
                Console.Clear();
                Console.Write(discription);
                if(int.TryParse(Console.ReadLine(), out int x) && x > low)
                {
                    Console.Clear();
                    return x;
                }
                Console.WriteLine("Sorry that is not a valid number");
                Thread.Sleep(2000);
                Console.Clear();
            } while(true);
        }

        /// <summary>
        /// Gets floating poit number form the user
        /// </summary>
        /// <returns>Floating point number</returns>
        public static float GetFloat()
        {
            float x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!float.TryParse(Console.ReadLine(), out x));
            return x;
        }

        /// <summary>
        /// Gets floating poit number form the user
        /// </summary>
        /// <param name="disc">Input custom number request</param>
        /// <returns>Floating point number</returns>
        public static float GetFloat(String disc)
        {
            float x;
            do
            {
                Console.Clear();
                Console.Write(disc);
            } while(!float.TryParse(Console.ReadLine(), out x));
            return x;
        }

        /// <summary>
        /// Askes user if they would like to continue player
        /// </summary>
        /// <returns>Bool true or false</returns>
        public static bool IsYes()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Would you like to continue (Y/N)? ");
            string awnser = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            if("yes".StartsWith(awnser))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Askes user a yes or no question
        /// </summary>
        /// <param name="description">Costom question you would like to ask the user</param>
        /// <returns>Bool true or false</returns>
        public static bool IsYes(string description)
        {
            {
                Console.Write(description);
                string awnser = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if("yes".StartsWith(awnser))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
