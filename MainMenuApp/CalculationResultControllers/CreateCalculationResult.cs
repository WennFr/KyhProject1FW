using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary.Interfaces;

namespace MainMenuApp.CalculationResultControllers
{
    public class CreateCalculationResult : ICreateResult
    {
        private IDbContext _dbContext;
        public CreateCalculationResult(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create()
        {
            while (true)
                {
                    Console.Clear();
                    double Num1, Num2;
                    double Result = 0.00;
                    char op;
                    try
                    {
                        Console.Write("Enter your First Number :  ");
                        Num1 = Convert.ToDouble(Console.ReadLine());

                        if (Double.IsInfinity(Num1))
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
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        if (Double.IsInfinity(Num2))
                        {
                            Console.WriteLine("Overflow");
                            Console.ReadKey();
                            continue;
                        }

                        if (Double.IsInfinity(Num1 / Num2))
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

                    Result = Calculator(Num1, Num2, op);
                    Console.WriteLine("\n{0} {1} {2} = {3}", Num1, op, Num2, Result);
                    Console.ReadKey();
                }

            }
        double Calculator(double v1, double v2, char op)
            {
                double Result = 0.00;

                switch (op)
                {
                    case '+':
                        Result = v1 + v2;
                        break;
                    case '-':
                        Result = v1 - v2;
                        break;
                    case '*':
                        Result = v1 * v2;
                        break;
                    case '/':
                        Result = v1 / v2;
                        break;
                }
                return Result;
            }


    }


    
}
