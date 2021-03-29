using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Shop
    {
        public static int upgradeCost = 50;
        public static int swordCost = 100;
        public static int medicinesCost = 20;

        public static void ShopInTown()
        {
            Console.Clear();
            Console.WriteLine("Welcome adventurer in the shop.");
            Console.WriteLine("You can buy upgrades and items here.");
            Console.WriteLine("You have: " + Character.Money +" talons");
            Console.WriteLine();
        }
        public static void Upgrade_1()
        {
            if (Character.Money >= upgradeCost)
            {
                Character.Money = Character.Money - upgradeCost;
                Character.MaxHp = Character.MaxHp + 30;
                Character.Hp = Character.Hp + 30;
                Character.Dmg += 3;
                upgradeCost += 25;
            }
            else
            {
                Console.WriteLine("You don't have enough money for the upgrade");

            }
        }
        public static void SwordOfDevine()
        {
            if (Character.Money >= swordCost)
            {
                Character.Money = Character.Money - swordCost;
                Character.Dmg += 7;
                swordCost += 50;
            }
            else
            {
                Console.WriteLine("You don't have enough money for the new sword of devine.");

            }

        }
        public static void Medicines()
        {
            if(Character.Money >= medicinesCost)
            {
                Character.Money -= medicinesCost;
                Character.Hp = Character.MaxHp;
            }
            else
            {
                Console.WriteLine("You don't have enogh money for medicines");
            }
        }
        public static void UpgradeInfo()
        {
            Console.WriteLine("Cost of the upgrade: " + upgradeCost);
            Console.WriteLine("Upgrade insert dmg by 3 and hp by 30.");
        }
        public static void SwordInfo()
        {
            Console.WriteLine("Cost of the sword: " + swordCost);
            Console.WriteLine("Upgrade insert dmg by 7");
        }
        public static void ShopInfo()
        {
            UpgradeInfo();
            SwordInfo();
        }
        
    }
}
