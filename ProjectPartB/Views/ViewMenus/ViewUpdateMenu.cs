using System;

namespace ProjectPartB.Views.ViewMenus
{
    public class ViewUpdateMenu
    {
        public static void PrintUpdateMenu()
        {
            Console.WriteLine("1: Update Course");
            Console.WriteLine("2: Update Trainer");
            Console.WriteLine("3: Update Student");
            Console.WriteLine("4: Update Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
        }
    }
}