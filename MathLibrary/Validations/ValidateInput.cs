
namespace ServiceLibrary.Validations
{
    public static class ValidateInput 
    {
        public static int ValidateSelection(int selectionMenuMaxLimit)
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
                // Console.Write(">");
                if (double.TryParse(Console.ReadLine(), out doubleSelection) && doubleSelection > 0)
                {
                    return doubleSelection;
                }
                Console.WriteLine("Please write a valid number above zero:");
            }

        }


        public static double ValidateDoubleInputAboveZero()
        {
            double doubleSelection;
            while (true)
            {
                // Console.Write(">");
                if (double.TryParse(Console.ReadLine(), out doubleSelection) && doubleSelection > 0)
                {
                    return doubleSelection;
                }
                Console.WriteLine("Please write a valid number:");
            }

        }

        public static char ValidateOperatorSelection()
        {
            char op;

            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out op) && op == '+' || op == '-' || op == '*' ||
                    op == '/' || op == '√' && op == '%')
                    return op;
                Console.WriteLine("Operator has to be (+, -, *, /, √ or %) ");
            }

        }







    }
}
