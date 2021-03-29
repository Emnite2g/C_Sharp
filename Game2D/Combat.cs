using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Combat
    {
        public static int CharacterAttack;
        public static int EnemyAttack;
        public static void CharacterAttack_1()
        {
            Random r = new Random();
            
            int random = r.Next(Character.Dmg - 5, Character.Dmg + 5);

            CharacterAttack = random;
        }
        public static void CharacterAttack_2()
        {
            Random r = new Random();

            int random = r.Next(Character.Dmg - 7, Character.Dmg + 10);

            CharacterAttack = random;

        }
        public static void CharacterAttack_3()
        {
            Random r = new Random();

            int random = r.Next(Character.Dmg - 10, Character.Dmg + 20);
            Character.Dmg -= 1;
            CharacterAttack = random;
        }
        public static void EnemyAttack_1()
        {
            Random r = new Random();
            int random = r.Next(Enemies.EnemyDmg / 2, Enemies.EnemyDmg + 3);
            EnemyAttack = random;
        }
        public static void CombatCharacterVsEnemy() 
        {
            while (Character.Hp > 0 && Enemies.EnemyHp > 0)
            {
                Console.Clear();
                Console.WriteLine("Character: ");
                Character.StatsInfo();
                Console.WriteLine("Enemy: ");
                Enemies.EnemyInfo();
                AttackInfo();
                AttackSelect();
                Console.WriteLine("You dealt " + CharacterAttack + " damage to the enemy");
                Enemies.EnemyHp -= CharacterAttack;
                EnemyAttack_1();
                Console.WriteLine("Enemy dealt " + EnemyAttack + " damage to you");
                Character.Hp -= EnemyAttack;
                Console.ReadLine();

            }
            IsDeadCharacter();
            IsEnemyDeafeated();
            Victory();
            LvlCheck();
            Console.ReadLine();
            BackAfterCombat();

        }
        public static void AfterCombat1Enemy()
        {
            IsDeadCharacter();
            IsEnemyDeafeated();
            Victory();
            LvlCheck();
            Console.ReadLine();
            BackAfterCombat();

        }
        public static void AfterCombat2Enemies()
        {
            IsDeadCharacter();
            IsEnemyDeafeated();
        }
        public static void NextEnemy()
        {
            Console.WriteLine("There's one more enemy, prepare yourself!");
            Character.Exp += Enemies.EnemyExp;
            Character.Money += Enemies.EnemyMoney;
            LvlCheck();
            Console.ReadLine();

        }
        public static void CombatCharacterVs1Enemy()
        {
            while (Character.Hp > 0 && Enemies.EnemyHp > 0)
            {
                Console.Clear();
                Console.WriteLine("Character: ");
                Character.StatsInfo();
                Console.WriteLine("Enemy: ");
                Enemies.EnemyInfo();
                AttackInfo();
                AttackSelect();
                Console.WriteLine("You dealt " + CharacterAttack + " damage to the enemy");
                Enemies.EnemyHp -= CharacterAttack;
                EnemyAttack_1();
                Console.WriteLine("Enemy dealt " + EnemyAttack + " damage to you");
                Character.Hp -= EnemyAttack;
                Console.ReadLine();

            }
        }
        public static void CombatCharacterVs2Enemies()
        {
            EnemyCountCheck(2);
            CombatCharacterVs1Enemy();
            AfterCombat2Enemies();
            NextEnemy();
            EnemyCountCheck(1);
            Console.Clear();
            CombatCharacterVs1Enemy();
            AfterCombat1Enemy();

        }
        public static void Combat2EnemiesLvl(int n)
        {
            Enemies.EnemyLvl(n);
            CombatCharacterVs1Enemy();
            AfterCombat2Enemies();
            NextEnemy();
            Enemies.EnemyLvl(n);
            CombatCharacterVs1Enemy();
            AfterCombat1Enemy();
        }
        public static void Combat2EnemiesAndBoss(int n)
        {
            Enemies.EnemyLvl(n);
            CombatCharacterVs1Enemy();
            AfterCombat2Enemies();
            NextEnemy();
            Enemies.EnemyLvl(n);
            CombatCharacterVs1Enemy();
            AfterCombatGuards();
            Console.ReadLine();
            Enemies.EnemyLvl(n+2);
            CombatCharacterVs1Enemy();
        }
        public static void AfterCombatGuards()
        {
            Console.Clear();
            Console.WriteLine("Final Boss The King");
        }
        public static void BackAfterCombat()
        {
            Console.Clear();
            Trips.TripSelectionInfo();
            Trips.TripSelction();
        }
        public static void AttackInfo()
        {
            Console.WriteLine("1.Normal Attack");
            Console.WriteLine("2.Heavy Attack");
            Console.WriteLine("3.Special Attack");
        }
        public static void AttackSelect()
        {
            string a = Console.ReadLine();
            if(a == "1")
            {
                CharacterAttack_1();
            }else if (a == "2")
            {
                CharacterAttack_2();
            }else if (a == "3")
            {
                CharacterAttack_3();
            }
            else
            {
                Console.WriteLine("Wrong Input!");
                AttackSelect();
            }
        }
        public static void IsDeadCharacter()
        {
            if(Character.Hp <= 0)
            {
                Console.Clear();
                Console.WriteLine("You are dead. Better luck next time.");
                Console.WriteLine("Game Over!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void IsEnemyDeafeated()
        {
            if(Enemies.EnemyHp <= 0)
            {
                Console.Clear();
                Console.WriteLine("Glorius Victory!");
                

            }
        }
        public static void Victory()
        {
            Character.Exp += Enemies.EnemyExp;
            Character.Money += Enemies.EnemyMoney;
        }
        public static void LvlCheck()
        {
            if(Character.Exp >= Character.NextLvl)
            {
                Character.Hp += 20;
                Character.MaxHp += 20;
                Character.Dmg += 5;
                Character.Exp -= Character.NextLvl;
                Character.NextLvl += 50;
                Console.WriteLine("New Lvl!");
                Character.StatsInfo();
            }
        }
        public static void EnemyCountCheck(int n)
        {
            if(Enemies.HowManyEnemies >= 1)
            {
                Enemies.EnemyLvl(n);
                Enemies.HowManyEnemies--;
            }
        }
    }
}
