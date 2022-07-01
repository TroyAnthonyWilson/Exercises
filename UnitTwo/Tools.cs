using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int x;
            bool isNumber;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
                if(int.TryParse(Console.ReadLine(), out x))
                {

                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid number");
                    Thread.Sleep(2000);
                    isNumber = true;
                }

            } while(isNumber);
            Console.Clear();
            return x;
        }

        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <returns>Positive int</returns>
        public static int GetInt(int low)
        {
            int x;
            bool isNumber;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
                if(int.TryParse(Console.ReadLine(), out x) && x > low)
                {

                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid number");
                    Thread.Sleep(2000);
                    isNumber = true;
                }

            } while(isNumber);
            Console.Clear();
            return x;
        }

        /// <summary>
        /// Gets a positive int form the user
        /// </summary>
        /// <param name="disc">Input custom number request</param>
        /// <returns>Positive int</returns>
        public static int GetInt(string disc)
        {
            int x;
            bool isNumber;
            do
            {
                Console.Clear();
                Console.Write(disc);
                if(int.TryParse(Console.ReadLine(), out x))
                {

                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid number");
                    Thread.Sleep(2000);
                    isNumber = true;
                }

            } while(isNumber);
            Console.Clear();
            return x;
        }

        /// <summary>
        /// Gets a int form the user
        /// </summary>
        /// <param name="disc">Input custom number request</param>
        /// <returns>Positive int</returns>
        public static int GetInt(string disc, int low)
        {
            int x;
            bool isNumber;
            do
            {
                Console.Clear();
                Console.Write(disc);
                if(int.TryParse(Console.ReadLine(), out x) && x > low)
                {

                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid number");
                    Thread.Sleep(2000);
                    isNumber = true;
                }

            } while(isNumber);
            Console.Clear();
            return x;
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
            do
            {
                Console.Clear();
                Console.Write("Would you like to continue (Y/N)? ");
                string awnser = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid answer");
                    Thread.Sleep(2000);
                }
            } while(true);
        }

        /// <summary>
        /// Askes user a yes or no question
        /// </summary>
        /// <param name="desc">Costom question you would like to ask the user</param>
        /// <returns>Bool true or false</returns>
        public static bool IsYes(string desc)
        {
            do
            {
                Console.Write(desc);
                string awnser = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if(awnser == "y" || awnser == "yes" || awnser == "yup")
                {
                    return true;
                }
                else if(awnser == "n" || awnser == "no" || awnser == "nope")
                {
                    return false;
                }
            } while(true);
        }
    }
}
