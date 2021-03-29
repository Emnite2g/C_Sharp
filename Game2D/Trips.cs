using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Trips
    {
        
        public static void TripSelction()
        {
            Console.Clear();            
            TripSelectionInfo();
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.Clear();
                Story.Trip1();
                Console.ReadLine();
                Console.Clear();
                Enemies.HowManyEnemiesLvl(1);
                Enemies.EnemyLvl(1);
                Combat.CombatCharacterVsEnemy();

            }
            else if (a == "2")
            {
                Console.Clear();
                Story.Trip2();
                Console.ReadLine();
                Console.Clear();
                Enemies.HowManyEnemiesLvl(1);
                Enemies.EnemyLvl(2);
                Combat.CombatCharacterVsEnemy();

            }
            else if (a == "3")
            {
                Console.Clear();
                Story.Trip3();
                Console.ReadLine();
                Combat.Combat2EnemiesLvl(2);                
            }
            else if (a == "4")
            {
                Console.Clear();
                Story.Trip4();
                Console.ReadLine();
                Combat.Combat2EnemiesLvl(3);                
            }
            else if (a == "5")
            {
                Console.Clear();
                Story.Trip5();
                Console.ReadLine();
                Combat.Combat2EnemiesAndBoss(3);                
                Console.Clear();
                Console.WriteLine("Well done!");
                Console.WriteLine("You win!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if(a== "b")
            {
                Menu.MenuCity();
            }
            else
            {
                Console.WriteLine("Wrong Input");
                TripSelction();
            }

        }
        public static void TripSelectionInfo()
        {
            Console.WriteLine("1.Problems in the city.");
            Console.WriteLine("2.Stolen goods");
            Console.WriteLine("3.Convoy");
            Console.WriteLine("4.Sabotage");
            Console.WriteLine("5.King");
            Console.WriteLine("b-back");
        }       

    }
}
