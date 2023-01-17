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






    }
}
