using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Trapeze
    {
        
        public static void TrapezePerimeter1()
        {
            Console.WriteLine("a + b + c +d");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleGreater0();
            Console.Write("d: ");
            double d = Functions.DoubleGreater0();
            double result = a + b + c + d;
            result = Math.Round(result, 2);
            Console.WriteLine("Perimeter of trapeze: " + result);
            Console.ReadLine();
        }
        public static void TrapezePerimeter2()
        {
            Console.WriteLine("a + 2b + c");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleGreater0();
            double result = a + 2.0 * b + c;
            result = Math.Round(result, 2);
            Console.WriteLine("Perimeter of trapeze: " + result);
            Console.ReadLine();
        }
        public static void TrapezAreaFormula1()
        {
            Console.WriteLine("(a+b)*h/2 ");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("h: ");
            double h = Functions.DoubleGreater0();
            double result = (a + b) * h / 2.0;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of trapeze:" + result);
            Console.ReadLine();
        }
        public static void TrapezAreaFormula2()
        {
            Console.WriteLine("m*h");
            Console.Write("m: ");
            double m = Functions.DoubleGreater0();
            Console.Write("h: ");
            double h = Functions.DoubleGreater0();
            double result = m * h;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of trapeze: " + result);
            Console.ReadLine();
        }
        public static void TrapezAreaFormula3()
        {
            Console.WriteLine("1/2c^2*sin(b)");
            Console.Write("c: ");
            double c = Functions.DoubleCheck();
            Console.Write("b: ");
            double b = Functions.DoubleCheck();
            double result = 0.5 * Math.Pow(c, 2) * Math.Sin(b);
            result = Math.Round(result, 2);
            Console.WriteLine("Area of trapeze: " + result);
            Console.ReadLine();
        }
    }
}
