
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
        public static decimal ValidateDecimalInputAboveZero()
        {
            decimal decimalSelection;
            while (true)
            {
                // Console.Write(">");
                if (decimal.TryParse(Console.ReadLine(), out decimalSelection) && decimalSelection > 0)
                {
                    return decimalSelection;
                }
                Console.WriteLine("Please write a valid number above zero:");
            }

        }





    }
}
