using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Services;

namespace ServiceLibrary.Messages
{
    public static class ServiceMessage
    {

        public static void PressEnterToContinue()
        {

            ColorService.ConsoleWriteLineDarkCyan($"{Environment.NewLine}Press enter to continue.");
            Console.ReadKey();

        }

        public static void Sucess()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Environment.NewLine}Success!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
