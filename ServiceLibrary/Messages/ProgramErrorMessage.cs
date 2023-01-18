using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ServiceLibrary.Services;

namespace ServiceLibrary.Messages
{
    public static class ProgramErrorMessage
    {

        public static void NoActiveResultsToView()
        {
            ColorService.ConsoleWriteLineRed($"Error: There are no active results to view");
        }

        public static void ChooseBetweenAvailableMenuNumbers()
        {
            ColorService.ConsoleWriteLineRed("Choose between the available numbers in the menu");

        }


    }
}
