using System;
using System.Collections.Generic;
using System.Text;

namespace SymulacjaRzutuKostka
{
    class Dice
    {
        static void DiceOne()
        {
            Console.WriteLine("---------");
            Console.WriteLine("|       | ");
            Console.WriteLine("|   O   |");
            Console.WriteLine("|       |");
            Console.WriteLine("---------");
            
        }
        static void DiceTwo()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| O     | ");
            Console.WriteLine("|       |");
            Console.WriteLine("|     O |");
            Console.WriteLine("---------");
        }
        static void DiceThree()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| O     | ");
            Console.WriteLine("|   O   |");
            Console.WriteLine("|     O |");
            Console.WriteLine("---------");
        }
        static void DiceFour()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| O   O | ");
            Console.WriteLine("|       |");
            Console.WriteLine("| O   O |");
            Console.WriteLine("---------");
        }
        static void DiceFive()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| O   O | ");
            Console.WriteLine("|   O   |");
            Console.WriteLine("| O   O |");
            Console.WriteLine("---------");
        }
        static void DiceSix()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| O   O | ");
            Console.WriteLine("| O   O |");
            Console.WriteLine("| O   O |");
            Console.WriteLine("---------");
        }
        public static void ThrowDice(int n)
        {
            switch (n)
            {
                case 1:
                    DiceOne();
                    break;
                case 2:
                    DiceTwo();
                    break;
                case 3:
                    DiceThree();
                    break;
                case 4:
                    DiceFour();
                    break;
                case 5:
                    DiceFive();
                    break;
                case 6:
                    DiceSix();
                    break;
            }
        }
    }
}
