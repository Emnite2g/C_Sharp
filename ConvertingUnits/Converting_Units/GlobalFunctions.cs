using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Units
{
    public static class GlobalFunctions
    {
        public static void Menu()
        {
            Console.WriteLine("Converting Units:");
            Console.WriteLine("1.Kg to Lbs or Lbs to Kg");
            Console.WriteLine("2.Celsius to Fahrenheit or Fahrenheit to Celsius");
            Console.WriteLine("3.Time");
            Console.WriteLine("4.Exit");

        }
        public static double DoubleInputCheck()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    double number = Convert.ToDouble(input);
                    return number;
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong Input!");
                    continue;
                }
            }
        }
    }
}
