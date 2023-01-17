using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Services
{
    public static class ColorService
    {
        public static void ConsoleWriteLineRed(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineGreen(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineBlue(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ConsoleWriteLineCyan(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineWhite(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineYellow(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineDarkGrey(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }



    }
}
