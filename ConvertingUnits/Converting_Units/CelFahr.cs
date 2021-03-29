using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Units
{
    public static class CelFahr
    {
        public static double CelToFahrDouble(double a)
        {
            double result = (a - 32.0) / 1.8;
            result = Math.Round(result, 2);
            return result;
        }

        public static double FahrToCelDouble(double a)
        {
            double result = a * 1.8 + 32.0;
            result = Math.Round(result, 2);
            return result;
        }
        public static void CelFahSelection()
        {
            Console.Write("(C)elsius or (F)ahrenheit: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "c":
                    Console.Write("Celsius: ");
                    double celToFah = GlobalFunctions.DoubleInputCheck();
                    double resultFah = CelToFahrDouble(celToFah);
                    Console.Write("Fahrenheit: " + resultFah);
                    Console.ReadLine();
                    break;
                case "f":
                    Console.Write("Fahrenheit: ");
                    double fahToCel = GlobalFunctions.DoubleInputCheck();
                    double resultCel = FahrToCelDouble(fahToCel);
                    Console.WriteLine("Celsius: " + resultCel);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    CelFahSelection();
                    break;
            }
        }
    }
}
