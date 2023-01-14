using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Messages
{
    public static class ServiceMessage
    {

        public static void PressEnterToContinue()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Environment.NewLine}Press enter to continue.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();

        }



    }
}
