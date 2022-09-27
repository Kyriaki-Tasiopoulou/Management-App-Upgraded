using System;

namespace ProjectPartB.Views.ViewMenus
{
    public class ViewDeleteMenu
    {
        public static void PrintDeleteMenu()
        {
            Console.WriteLine("1: Delete Course");
            Console.WriteLine("2: Delete Trainer");
            Console.WriteLine("3: Delete Student");
            Console.WriteLine("4: Delete Assignment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("E: Press 'E' to go to Back");
            Console.ResetColor();
        }
    }
}