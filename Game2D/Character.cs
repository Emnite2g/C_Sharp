using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Character
    {
        public static int Hp = 100;
        public static int Dmg = 10;
        public static int Exp = 0;
        public static int TalentsLeft = 5;
        public static int MaxHp = 100;
        public static int NextLvl = 100;
        public static int Money = 100;
        public static bool Talents = true;
        public static void SelectTalents()
        {
            Console.Clear();
            Console.WriteLine("Select your's talents: ");            
            StatsInfo();
            SelectingTalents();

            
        }
        public static void StatsInfo()
        {
            Console.WriteLine("Dmg: " + Dmg);
            Console.WriteLine("Hp: " + Hp + "/" + MaxHp);
            Console.WriteLine("Exp: " + Exp + "/" + NextLvl);

        }
        public static void SelectingTalents()
        {
            while (TalentsLeft > 0)
            {
                Console.WriteLine("Press h to upgrade hp or d to upgrade dmg");
                Console.WriteLine("Talents left: " + TalentsLeft);
                string Upgrade = Console.ReadLine();
                if(Upgrade == "h")
                {
                    Hp = Hp + 10;
                    MaxHp = MaxHp + 10;
                    TalentsLeft--;
                }
                else if(Upgrade == "d")
                {
                    Dmg = Dmg + 1;
                    TalentsLeft--;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    Console.ReadLine();
                }
                Console.Clear();
                StatsInfo();
                
            }
            


        }
    }
}
