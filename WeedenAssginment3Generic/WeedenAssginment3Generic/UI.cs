using System;
using static System.Console;
namespace WeedenAssginment3Generic
{
    public class UI
    {
        public void Start()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("\nHello this application will add two numbers of 3 different types: double, int, and float.\n" +
                "It will allow you to choose the type, and will use the same method regardless of type chosen,\n" +
                "but it will specify the type to the method.");
            ForegroundColor = ConsoleColor.White;
        }

        public string AskForType()
        {
            string val = "";
            while (val == "")
            {
                WriteLine("\n\nEnter 1 for double, 2 for int, 3 for float, type 0 to exit.");
                val = ReadLine();
                if (val == "0")
                {
                    Environment.Exit(0);
                }
                else if (val == "1")
                {
                    return "double";
                }
                else if (val == "2")
                {
                    return "int";
                }
                else if (val == "3")
                {
                    return "float";
                }
                else
                {
                    val = "";
                    WriteLine("\nThat choice did not correspond to a menu item, try again.");
                }
            }
            //unreached
            return "";
        }

        public string GetNumber(string firstOrSecond)
        {
            WriteLine("\n\nEnter the {0} number.", firstOrSecond);
            return ReadLine();
        }

        public void DisplayResponse(string[] response)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n\nAdding...\n\n{0} + {1} = {2}.", response);
            ForegroundColor = ConsoleColor.White;
        }

        public bool Continue()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\n\nWould you like to continue? Hit any key (not q) to continue, or q to quit.");
            var key = ReadKey();
            if(key.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
            ForegroundColor = ConsoleColor.White;
            return true;
        }
    }
}
