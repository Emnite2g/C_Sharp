using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Units
{
    class Program
    {
        static void Main(string[] args)
        {           
            
                string unitSelectionChoice = "";
                while (true)
                {

                    GlobalFunctions.Menu();
                    unitSelectionChoice = Console.ReadLine();
                    switch (unitSelectionChoice)
                    {
                        case "1":
                            KgLbs.KgLbsSelection();
                            break;
                        case "2":
                            CelFahr.CelFahSelection();
                            break;
                        case "3":
                            Time.TimeSelection();
                            break;
                        case "4":
                            Environment.Exit(0);
                            break;

                    }
                    Console.Clear();

                }

            
        }
    }
}
