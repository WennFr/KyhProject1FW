namespace ServiceLibrary.Services
{
    public static class UserInputService
    {
        public static int ValidateMenuSelection(int selectionMenuMaxLimit)
        {
            int intSelection;
            Console.WriteLine($"{Environment.NewLine}Menu select:");
            while (true)
            {
                Console.Write("> ");
                if (int.TryParse(Console.ReadLine(), out intSelection) && intSelection >= 0 && intSelection <= selectionMenuMaxLimit)
                    return intSelection;

                Console.WriteLine("Choose between the available menu numbers");
            }
        }


        public static double ValidateDoubleInput()
        {
            double doubleSelection;
            while (true)
            {
                Console.Write($"{Environment.NewLine}>");
                if (double.TryParse(Console.ReadLine(), out doubleSelection))
                {
                    return doubleSelection;
                }
                Console.WriteLine("Please write a valid number:");




            }

        }


        public static double ValidateDoubleInputAboveZero()
        {
            double doubleSelection;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out doubleSelection) && doubleSelection > 0)
                {
                    return doubleSelection;
                }
                Console.WriteLine("Please write a valid number above zero:");
            }

        }

        public static char ValidateOperatorSelection()
        {
            char op;
            int opSelectionNumber;

            while (true)
            {
                Console.Write($"{Environment.NewLine}>");
                if (char.TryParse(Console.ReadLine(), out op) && op == '+' || op == '-' || op == '*' ||
                    op == '/' || op == '√' && op == '%')
                    return op;

                if (int.TryParse(Convert.ToString(op), out opSelectionNumber) && opSelectionNumber > 0 && opSelectionNumber <= 6)
                {
                    switch (opSelectionNumber)
                    {
                        case 1:
                            op = '+';
                            return op;
                        case 2:
                            op = '-';
                            return op;
                        case 3:
                            op = '*';
                            return op;
                        case 4:
                            op = '/';
                            return op;
                        case 5:
                            op = '√';
                            return op;
                        case 6:
                            op = '%';
                            return op;
                    }
                }
                Console.WriteLine($"{Environment.NewLine}Operator has to be (1.+, 2.-,3.*,4./,5.√ or 6.%) ");
            }

        }

        public static bool ValidateTrueOrFalseUserChoice()
        {
            while (true)
            {
                var userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "y" || userChoice.ToLower() == "yes")
                    return true;

                else if (userChoice.ToLower() == "n" || userChoice.ToLower() == "no")
                    return false;

                Console.WriteLine("Choose an option: ");
            }

        }







    }
}
