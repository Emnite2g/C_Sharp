using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class MenuChoice
    {
        public static void AreaMenuChoice()
        {                     
                Menu.AreasMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        TriangleAreaChoice();
                        break;
                    case "2":
                        SquareChoice();
                        break;
                    case "3":
                        TrapezeAreaChoice();
                        break;
                    case "4":
                        Circle.AreaCircleFormula();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        AreaMenuChoice();
                        break;
                }            
        }
        public static void PerimeterMenuChoice()
        {                        
                Menu.AreasMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        TrianglePerimeterChoice();
                        break;
                    case "2":
                        Square.SquarePerimeter();
                        break;
                    case "3":
                        TrapezePerimeterChoice();
                        break;
                    case "4":
                        Circle.CirclePerimeter();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        PerimeterMenuChoice();
                        break;                
            }
        }
        public static void TriangleAreaChoice()
        {
            Menu.TriangleAreaMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Triangle.TriangleAreaFormula1();
                    break;
                case "2":
                    Triangle.TriangleAreaFormula2();
                    break;
                case "3":
                    Triangle.TriangleAreaFormula3();
                    break;
                case "4":
                    Triangle.TriangleAreaFormula4();
                    break;
                case "5":
                    Triangle.TriangleAreaFormula5();
                    break;
                case "6":
                    Triangle.TriangleAreaFormula6();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    TriangleAreaChoice();
                    break;
            }
        }         
       
        public static void TrianglePerimeterChoice()
        {
            Menu.TrianglePerimeterMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Triangle.TrianglePerimeter1();
                    break;
                case "2":
                    Triangle.TrianglePerimeter2();
                    break;
                case "3":
                    Triangle.TrainglePerimeter3();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    TrianglePerimeterChoice();
                    break;
            }
        }
        public static void SquareChoice()
        {
            Menu.SquareAreaMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Square.SquareAreaFormula1();
                    break;
                case "2":
                    Square.SquareAreaFormula2();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    SquareChoice();
                    break;
            }
        }
        public static void TrapezeAreaChoice()
        {
            Menu.TrapezeAreaMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Trapeze.TrapezAreaFormula1();
                    break;
                case "2":
                    Trapeze.TrapezAreaFormula2();
                    break;
                case "3":
                    Trapeze.TrapezAreaFormula3();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    TrapezeAreaChoice();
                    break;
            }
        }
        public static void TrapezePerimeterChoice()
        {
            Menu.TrapezePerimeterMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Trapeze.TrapezePerimeter1();
                    break;
                case "2":
                    Trapeze.TrapezePerimeter2();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    TrapezePerimeterChoice();
                    break;
            }
        }
        public static void MeanChoice()
        {
            Console.WriteLine("Arithmetic mean(a), Geometric(g),Back (b)");
            string input = Console.ReadLine();

            input = input.ToLower().Trim();
            switch (input)
            {
                case "a":
                    Mean.ArithmeticMeanSelection();
                    break;
                case "g":
                    Mean.GeometricMeanSelection();
                    break;
                case "b":
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    MeanChoice();
                    break;
            }
        }

    }
}
