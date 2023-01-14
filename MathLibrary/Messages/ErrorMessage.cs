using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ServiceLibrary.Messages
{
    public static class ErrorMessage
    {

        public static void NoActiveResultsToView()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: There are no active results to view");
            Console.ForegroundColor = ConsoleColor.Gray;

        }



    }
}
