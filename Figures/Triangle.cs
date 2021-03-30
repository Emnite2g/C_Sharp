using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Triangle
    {       
        
       
        public static void TrianglePerimeter1()
        {
            Console.WriteLine("a + b + c");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleGreater0();
            double result = a + b + c;
            Console.WriteLine("Perimeter of the triangle: " + result);
            Console.ReadLine();

        }
        public static void TrianglePerimeter2()
        {
            Console.WriteLine("a + 2b");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            double result = a + 2 * b;
            Console.WriteLine("Perimeter of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TrainglePerimeter3()
        {
            Console.WriteLine("3a");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            double result = 3 * a;
            result = Math.Round(result, 2);
            Console.WriteLine("Perimeter of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula1()
        {
            Console.WriteLine("1/2ah");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("h: ");
            double h = Functions.DoubleGreater0();
            double result = 0.5 * a * h;
            result = Math.Round(result, 2);
            Console.WriteLine("Perimeter of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula2()
        {
            Console.WriteLine("1/2absin(y)");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("y: ");
            double y = Functions.DoubleCheck2PI();
            double result = 0.5 * a * b * Math.Sin(y);
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula3()
        {
            Console.WriteLine("(p(p−a)(p−b)(p−c))^1/2");
            Console.Write("p: ");
            double p = Functions.DoubleGreater0();
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleGreater0();
            double result = p * (p - a) * (p - b) * (p - c);
            result = Math.Pow(result, 1.0 / 2.0);
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula4()
        {
            Console.WriteLine("abc/4R");
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleGreater0();
            Console.Write("R: ");
            double R = Functions.DoubleGreater0();
            double result = (a * b * c) / 4 * R;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula5()
        {
            Console.WriteLine("2R^2sin(a)sin(b)sin(c)");
            Console.Write("R: ");
            double R = Functions.DoubleGreater0();
            Console.Write("a: ");
            double a = Functions.DoubleCheck2PI();
            Console.Write("b: ");
            double b = Functions.DoubleCheck2PI();
            Console.Write("c: ");
            double c = Functions.DoubleCheck2PI();
            double result = 2 * Math.Pow(R, 2) * Math.Sin(a) * Math.Sin(b) * Math.Sin(c);
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the triangle: " + result);
            Console.ReadLine();
        }
        public static void TriangleAreaFormula6()
        {
            Console.WriteLine("r(a+b+c)/2");
            Console.Write("r: ");
            double r = Functions.DoubleGreater0();
            Console.Write("a: ");
            double a = Functions.DoubleGreater0();
            Console.Write("b: ");
            double b = Functions.DoubleGreater0();
            Console.Write("c: ");
            double c = Functions.DoubleCheck();
            double result = r * (a + b + c) / 2;
            result = Math.Round(result, 2);
            Console.WriteLine("Area of the triangle: " + result);
            Console.ReadLine();

        }

    }
}
