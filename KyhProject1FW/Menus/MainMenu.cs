using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1FW.Menus
{
    public class MainMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine($"Project 1 - Main Menu {Environment.NewLine}");
            Console.WriteLine("1) Shapes");
            Console.WriteLine("2) Calculator");
            Console.WriteLine("3) Rock,Paper,Scissors");
            Console.WriteLine("0) Quit");
        }

        public void ShapesMenu() 
        {
            Console.WriteLine($" Shapes {Environment.NewLine}");
            Console.WriteLine("1) Create shapes");
            Console.WriteLine("2) View shapes");
            Console.WriteLine("3) Edit shapes");
            Console.WriteLine("4) Delete shapes");
            Console.WriteLine("0) Go back to main menu");

        }

        public void ChooseAShapeToCreateMenu()
        {
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Parallelogram");
            Console.WriteLine("3) Triangle");
            Console.WriteLine("4) Rhombus");
            Console.WriteLine("0) Go back to previous menu");

        }

        public void CalculatorMenu() 
        {
            Console.WriteLine($" Calculator {Environment.NewLine}");
            Console.WriteLine("1) Create calculations");
            Console.WriteLine("2) View calculations");
            Console.WriteLine("3) Edit calculations");
            Console.WriteLine("4) Delete calculations");
            Console.WriteLine("0) Go back to main menu");

        }
        public void ChooseAnOperatorMenu()
        {
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) √");
            Console.WriteLine("6) %");
        }

        public void GameMenu()
        {
            Console.WriteLine($"Rock,Paper,Scissors {Environment.NewLine}");
            Console.WriteLine("1) Play Game");
            Console.WriteLine("2) View Highscore");

        }

    }
}
