using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace CalculatorApp.CalculationResultControllers
{
    public class CreateCalculationResult : ICreateResult
    {
        private IDbContext _dbContext;
        private ICalculatorContext _calculatorContext;
        private ICalculatorStrategy _additionStrategy;
        private ICalculatorStrategy _subtractionStrategy;
        private ICalculatorStrategy _multiplicationStrategy;
        private ICalculatorStrategy _divisionStrategy;
        public CreateCalculationResult(IDbContext dbContext, ICalculatorContext calculatorContext, ICalculatorStrategy additionStrategy, 
            ICalculatorStrategy subtractionStrategy, ICalculatorStrategy multiplicationStrategy, ICalculatorStrategy divisionStrategy)
        {
            _dbContext = dbContext;
            _calculatorContext = calculatorContext;
            _additionStrategy = additionStrategy;
            _subtractionStrategy = subtractionStrategy;
            _multiplicationStrategy = multiplicationStrategy;
            _divisionStrategy = divisionStrategy;
        }

        public void Create()
        {
            while (true)
                { 
                    Console.Clear();
                    double num1, num2;
                    double result = 0.00;
                    char op;
                    try
                    {
                        Console.Write("Enter your First Number :  ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        if (Double.IsInfinity(num1))
                        {
                            Console.WriteLine("Overflow");
                            Console.ReadKey();
                            continue;
                        }
                        Console.Write("Enter an Operator  (+, -, * or /): ");
                        while (true)
                        {
                            if (char.TryParse(Console.ReadLine(), out op) && op == '+' || op == '-' || op == '*' ||
                                op == '/')
                                break;
                            Console.WriteLine("Operator has to be (+, -, * or /) ");
                        }

                    Console.Write("Enter your Second Number :");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        if (Double.IsInfinity(num2))
                        {
                            Console.WriteLine("Overflow");
                            Console.ReadKey();
                            continue;
                        }

                        if (Double.IsInfinity(num1 / num2))
                        {
                            Console.WriteLine("Error: " + "Attempted to divide by zero0");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        continue;
                    }

                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                        Console.ReadKey();
                        continue;
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                        Console.ReadKey();
                        continue;
                    }

                    switch (op)
                    {
                        case '+':
                            _calculatorContext.SetStrategy(_additionStrategy);
                            break;
                        case '-':
                            _calculatorContext.SetStrategy(_subtractionStrategy);
                            break;
                        case '*':
                            _calculatorContext.SetStrategy(_multiplicationStrategy);
                            break;
                        case '/':
                            _calculatorContext.SetStrategy(_divisionStrategy);
                            break;
                    }

                    result = _calculatorContext.ExecuteStrategy(num1, num2);
                    Console.WriteLine("\n{0} {1} {2} = {3}",$" {num1} {op} {num2} {result}");
                    Console.ReadKey();
                }

            }
        


    }


    
}
