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


        public static void ConsoleWriteRed(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteLineGreen(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteGreen(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stringToColor);
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

        public static void ConsoleWriteWhite(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        public static void ConsoleWriteLineYellow(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleWriteYellow(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        public static void ConsoleWriteLineDarkGrey(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ConsoleWriteLineDarkMagenta(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ConsoleWriteLineDarkGreen(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ConsoleWriteLineDarkCyan(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ConsoleWriteDarkCyan(string stringToColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(stringToColor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }



    }
}
