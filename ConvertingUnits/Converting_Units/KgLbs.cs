using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Units
{
    public static class KgLbs
    {
        public static double KgToLbsFunction(double a)
        {
            double result = a / 0.45;
            result = Math.Round(result, 2);
            return result;
        }
        public static double LbsToKgFunction(double a)
        {
            double result = a * 0.45;
            result = Math.Round(result, 2);
            return result;
        }
        public static void KgLbsSelection()
        {

            Console.Write("(K)g or (L)bs: ");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            switch (choice)
            {
                case "k":
                case "kg":
                    Console.Write("Kg: ");
                    double KgToLbs = GlobalFunctions.DoubleInputCheck();
                    double resultLbs = KgToLbsFunction(KgToLbs);
                    Console.WriteLine("Lbs: " + resultLbs);
                    Console.ReadLine();
                    break;
                case "l":
                case "lbs":
                    Console.Write("Lbs: ");
                    double LbstoKg = GlobalFunctions.DoubleInputCheck();
                    double resultKg = LbsToKgFunction(LbstoKg);
                    Console.WriteLine("Kg: " + resultKg);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    KgLbsSelection();
                    break;

            }
        }
    }
}
