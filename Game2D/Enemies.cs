using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Enemies
    {
        public static int EnemyHp = 50;
        public static int EnemyMaxHp = 50;
        public static int EnemyDmg = 5;
        public static int EnemyExp = 40;
        public static int EnemyMoney = 30;
        public static int HowManyEnemies = 2;
        public static void EnemyLvl(int n)
        {
            EnemyHp = 50 * n;
            EnemyMaxHp = 50 * n;
            EnemyDmg = 5 * n;
            EnemyExp = 40 * n;
            EnemyMoney = 40 * n;

        }
        public static void HowManyEnemiesLvl(int n)
        {
            HowManyEnemies = n;
        }
        public static void EnemyInfo()
        {
            Console.WriteLine("Enemy Hp: " + EnemyHp);
            Console.WriteLine("Enemy Dmg: " + EnemyDmg);
            Console.WriteLine("Enemy Exp: " + EnemyExp);            
            Console.WriteLine("Money: " + EnemyMoney);
        }

    }
}
