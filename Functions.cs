using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Functions
    {
        public static double DoubleCheck()
        {
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                return a;
            }
            catch
            {
                Console.WriteLine("Wrong Input!");                
                return DoubleCheck();
            }
        }
        public static double DoubleGreater0()
        {
            double a = DoubleCheck();
            if(a > 0)
            {
                return a;
            }
            else
            {
                Console.WriteLine("Value lower than or equal to 0!");
                return DoubleGreater0();
            }
        }
        public static double DoubleCheck2PI()
        {
            double a = DoubleGreater0();
            if(a < Math.PI * 2)
            {
                return a;
            }
            else
            {
                Console.WriteLine("Value must be lower than 2 PI!");
                return DoubleCheck2PI();
            }

        }
    }
}
