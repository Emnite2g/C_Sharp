using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Units
{
    public class Time
    {
        public static double Devine60(double a)
        {
            double result = a / 60.0;
            result = Math.Round(result, 2);
            return result;
        }
        public static double Multiply60(double a)
        {
            double result = a * 60.0;
            result = Math.Round(result, 2);
            return result;
        }
        public static void TimeSelection()
        {
            Console.Write("(S)econds, (M)inutes, (H)ours: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "s":
                    SecSelection();
                    Console.ReadLine();
                    break;
                case "m":
                    MinSelection();
                    Console.ReadLine();
                    break;
                case "h":
                    HoursSelection();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    TimeSelection();
                    break;
            }
        }
        static void SecSelection()
        {
            Console.Write("Seconds: ");
            double seconds = GlobalFunctions.DoubleInputCheck();
            Console.Write("Seconds to (M)inutes or (H)ours: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "m":
                    double resultMin = Devine60(seconds);
                    Console.WriteLine("Minutes: " + resultMin);
                    break;
                case "h":
                    double resultHours = Devine60(Devine60(seconds));
                    Console.WriteLine("Hours: " + resultHours);
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    SecSelection();
                    break;
            }
        }
        static void MinSelection()
        {
            Console.Write("Minutes: ");
            double minutes = GlobalFunctions.DoubleInputCheck();
            Console.Write("Minutes to (S)econds or (H)ours: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "s":
                    double resultSec = Multiply60(minutes);
                    Console.WriteLine("Seconds: " + resultSec);
                    break;
                case "h":
                    double resultHours = Devine60(minutes);
                    Console.WriteLine("Hours: " + resultHours);
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    MinSelection();
                    break;
            }
        }
        static void HoursSelection()
        {
            Console.Write("Hours: ");
            double hours = GlobalFunctions.DoubleInputCheck();
            Console.Write("Hours to (S)econds or (M)inutes: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "s":
                    double resultSec = Multiply60(Multiply60(hours));
                    Console.WriteLine("Seconds: " + resultSec);
                    break;
                case "m":
                    double resultMin = Multiply60(hours);
                    Console.WriteLine("Minutes: " + resultMin);
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    HoursSelection();
                    break;
            }
        }
    }
}
