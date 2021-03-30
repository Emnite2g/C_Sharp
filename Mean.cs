using System;
using System.Collections.Generic;
using System.Text;

namespace PolaFigur
{
    public class Mean
    {
        
       
        public static void ArithmeticMeanSelection()
        {
            Console.Write("Enter the count of numbers: ");
            int CountArithmeticNumbers = 0;            
            CountArithmeticNumbers = CountOfNumbers();
            ArithmeticMean(CountArithmeticNumbers);
            Console.ReadLine();
        }
        public static void GeometricMeanSelection()
        {
            Console.Write("Enter the count of numbers: ");
            int CountGeometricNumbers = CountOfNumbers();
            GeometricMean(CountGeometricNumbers);
            Console.ReadLine();
        }
        

        
        static int CountOfNumbers()
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
            catch
            {
                Console.WriteLine("Wrong Input!");
                return CountOfNumbers();

            }
        }
        public static void ArithmeticMean(int n)
        {

            double temp, result;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: " + (i + 1));
                temp = Functions.DoubleCheck();
                sum += temp;
            }
            result = Math.Round(sum / n, 2);
            Console.WriteLine("Arithmetic mean: " + result);

        }
        public static void GeometricMean(int n)
        {
            double power = 1.0 / n;
            double temp, result;
            double sum = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: " + (i + 1));
                temp = Functions.DoubleGreater0();
                sum *= temp;
            }            
            result = Math.Pow(sum, power);
            result = Math.Round(result, 2);
            Console.WriteLine("Geometric mean: " + result);
        }
    }
}
