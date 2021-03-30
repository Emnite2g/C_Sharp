using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Circle
    {
        public static void CirclePerimeter()
        {
            Console.WriteLine("2PIr");
            Console.Write("r: ");
            double r = Functions.DoubleGreater0();
            double result = 2 * Math.PI * r;
            result = Math.Round(result, 2);
            Console.WriteLine("Perimeter of Circle: " + result);
            Console.ReadLine();
        }
        public static void AreaCircleFormula()
        {
            Console.WriteLine("PIr^2");
            Console.Write("r: ");
            double r = Functions.DoubleGreater0();
            double result = Math.PI * r * r;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of circle: " + result);
            Console.ReadLine();
        }

    }
}
