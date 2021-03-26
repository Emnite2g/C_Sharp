using System;

namespace SymulacjaRzutuKostka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            while (true)
            {
                Console.WriteLine("1.Throw a Dice");
                Console.WriteLine("2.Throw a Dice Twice");
                Console.WriteLine("3.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":                        
                        int numberOfMeshes = random.Next(1, 6);
                        Dice.ThrowDice(numberOfMeshes);
                        break;
                    case "2":
                        int numberOfMeshes1 = random.Next(1, 6);
                        int numberOfMeshes2 = random.Next(1, 6);
                        Dice.ThrowDice(numberOfMeshes1);
                        Dice.ThrowDice(numberOfMeshes2);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
