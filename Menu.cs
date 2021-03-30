using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("1.Areas of figures");
            Console.WriteLine("2.Perimeters of figures");
            Console.WriteLine("3.Arithmetic and geometric mean");
            Console.WriteLine("4.Exit");
        }
        public static void AreasMenu()
        {
            Console.WriteLine("1.Triangle");
            Console.WriteLine("2.Square");
            Console.WriteLine("3.Trapeze");
            Console.WriteLine("4.Circle");
            Console.WriteLine("5.Back");
        }
        public static void SquareAreaMenu()
        {
            Console.WriteLine("1.a^2");
            Console.WriteLine("2.1/2d^2");
            Console.WriteLine("3.Back");
        }
        public static void TriangleAreaMenu()
        {
            Console.WriteLine("1.1/2ah");
            Console.WriteLine("2.1/2absin(y)");
            Console.WriteLine("3.(p(p−a)(p−b)(p−c))^1/2");
            Console.WriteLine("4.abc/4R");
            Console.WriteLine("5.2R^2sin(a)sin(b)sin(c)");
            Console.WriteLine("6.r(a+b+c)/2");
            Console.WriteLine("7.Back");
        }
        public static void TrapezeAreaMenu()
        {
            Console.WriteLine("1.(a+b)*h/2 ");
            Console.WriteLine("2.m*h");
            Console.WriteLine("3.1/2c^2*sin(b)");
            Console.WriteLine("4.Back");
        }
        public static void TrapezePerimeterMenu()
        {
            Console.WriteLine("1.a + b + c +d");
            Console.WriteLine("2.a + 2b + c");
            Console.WriteLine("3.Back");
        }
        public static void TrianglePerimeterMenu()
        {
            Console.WriteLine("1.a + b + c");
            Console.WriteLine("2.a + 2b");
            Console.WriteLine("3.3a");
            Console.WriteLine("4.Back");
        }
    }
}
