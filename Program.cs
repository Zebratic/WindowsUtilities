using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            menu:
            BetterConsole.Clear();
            BetterConsole.WriteLine("Welcome to Windows Utitlites!", ConsoleColor.Cyan, true);
            BetterConsole.WriteLine();
            BetterConsole.WriteNumber(1, "Activate Windows");
            BetterConsole.WriteNumber(2, "Upgrade Windows");
            BetterConsole.WriteNumber(3, "Manage Administrator Account");
            ConsoleKeyInfo key = BetterConsole.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                ActivateWindowsMenu();
            }
            else if (key.Key == ConsoleKey.D2)
            {

            }
            else if (key.Key == ConsoleKey.D3)
            {

            }
            goto menu;
        }

        public static void ActivateWindowsMenu()
        {
            menu:
            BetterConsole.Clear();
            BetterConsole.WriteLine("Activate Windows", ConsoleColor.Cyan, true);
            BetterConsole.WriteLine();
            BetterConsole.WriteNumber(1, "Windows 10 Home");
            BetterConsole.WriteNumber(2, "Windows 10 Home N");
            BetterConsole.WriteNumber(3, "Windows 10 Pro");
            BetterConsole.WriteNumber(4, "Windows 10 Pro N");
            BetterConsole.WriteNumber(5, "Windows 10 Enterprise");
            BetterConsole.WriteNumber(6, "Back");
            ConsoleKeyInfo key = BetterConsole.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                BetterConsole.Clear();
                BetterConsole.WriteLine("Activating Windows 10 Home... Please wait...", ConsoleColor.Cyan);
                Activation.ActivateWindowsHome();
                BetterConsole.WriteLine("Done! Please check if your windows is activated!", ConsoleColor.Cyan);
                BetterConsole.ReadLine();
            }
            else if (key.Key == ConsoleKey.D2)
            {
                BetterConsole.Clear();
                BetterConsole.WriteLine("Activating Windows 10 Home N... Please wait...", ConsoleColor.Cyan);
                Activation.ActivateWindowsHomeN();
                BetterConsole.WriteLine("Done! Please check if your windows is activated!", ConsoleColor.Cyan);
                BetterConsole.ReadLine();
            }
            else if (key.Key == ConsoleKey.D3)
            {
                BetterConsole.Clear();
                BetterConsole.WriteLine("Activating Windows 10 Pro... Please wait...", ConsoleColor.Cyan);
                Activation.ActivateWindowsPro();
                BetterConsole.WriteLine("Done! Please check if your windows is activated!", ConsoleColor.Cyan);
                BetterConsole.ReadLine();
            }
            else if (key.Key == ConsoleKey.D4)
            {
                BetterConsole.Clear();
                BetterConsole.WriteLine("Activating Windows 10 Pro N... Please wait...", ConsoleColor.Cyan);
                Activation.ActivateWindowsProN();
                BetterConsole.WriteLine("Done! Please check if your windows is activated!", ConsoleColor.Cyan);
                BetterConsole.ReadLine();
            }
            else if (key.Key == ConsoleKey.D5)
            {
                BetterConsole.Clear();
                BetterConsole.WriteLine("Activating Windows 10 Enterprise... Please wait...", ConsoleColor.Cyan);
                Activation.ActivateWindowsEnterprise();
                BetterConsole.WriteLine("Done! Please check if your windows is activated!", ConsoleColor.Cyan);
                BetterConsole.ReadLine();
            }
            else if (key.Key == ConsoleKey.D6)
            {
                return;
            }
            goto menu;
        }
    }
}
