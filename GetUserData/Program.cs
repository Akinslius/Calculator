using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A basic project to get user data");
            GetUserData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            //Get User's name and age
            Console.WriteLine("Please enter your Name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Please enter your Age");
            string UserAge = Console.ReadLine();

            //change color
            ConsoleColor BgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;

            //echo to the console
            Console.WriteLine("Hello {0}! You are {1} years old.", UserName, UserAge);

            Console.ForegroundColor = BgColor;

        }
    }
}
