using System;

namespace PolaFigur
{
    class Program
    {                        
               
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.MainMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        MenuChoice.AreaMenuChoice();
                        break;
                    case "2":
                        MenuChoice.PerimeterMenuChoice();
                        break;
                    case "3":
                        MenuChoice.MeanChoice();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        Console.ReadLine();                        
                        break;
                }
                Console.Clear();
            }
        }
    }
}
