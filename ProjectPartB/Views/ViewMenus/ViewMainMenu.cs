using System;

namespace ProjectPartB.Views.ViewMenus
{
    public class ViewMainMenu
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("Press 1 to Read Data");
            Console.WriteLine("Press 2 to Create/Relate Data");
            Console.WriteLine("Press 3 to Update Data");
            Console.WriteLine("Press 4 to Delete Data");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 'E' to Exit Program");
            Console.ResetColor();
        }
    }
}