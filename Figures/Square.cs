using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Square
    {
        public static void SquareAreaFormula1()
        {
            Console.WriteLine("a^2");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            double result = a * a;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the square: " + result);
            Console.ReadLine();
        }
        public static void SquareAreaFormula2()
        {
            Console.WriteLine("1/2d^2");
            Console.Write("d: ");
            double d = Functions.DoubleGreater0();
            double result = 0.5 * d * d;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the square: " + result);
            Console.ReadLine();
        }
        public static void SquarePerimeter()
        {
            Console.WriteLine("4a");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            double result = 4 * a;
            Console.WriteLine("Perimeter of the square: " + result);
            Console.ReadLine();

        }
    }
}
