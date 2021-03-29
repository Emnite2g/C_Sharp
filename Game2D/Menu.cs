using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Menu
    {
        public static string name = "";
        public static void MenuStart()
        {
            Console.WriteLine("Trip of the mountain King!");
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Author");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Exit");
        }
        public static void SelectMenu()
        {

            //int menuInput = Convert.ToInt32(Console.ReadLine());
           
            string checkedInput = Console.ReadLine();
            
            switch (checkedInput)
            {
                case "1":
                    if(Menu.name == "")
                    {
                        CharacterName();
                        //Console.ReadLine();
                        Story.Story1();
                        Character.SelectTalents();
                    }
                    
                    MenuCity();
                    
                    
                    break;
                case "2":
                    Story.Author();
                    
                    Menu.Back();
                    break;
                case "3":
                    Console.Clear();
                    Save.SaveTxtLines();
                    Menu.Back();
                    break;
                case "4":
                    Console.Clear();
                    Save.LoadTxt();
                    Menu.Back();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong Input Try Again!");
                    SelectMenu();
                    break;

            }
        }
        /*public int SelectMenuCheck (string a)
        {
            if(a == "1" || a=="2" || a=="3" || a=="4" || a == "5")
            {
                checkedInput = Convert.ToInt32(a);
            }

        }*/

        public static void CharacterName()
        {
            Console.Clear();
            Console.Write("Enter character's name: ");
            Menu.name = Console.ReadLine();
            Console.WriteLine("Hello " + Menu.name + "!");
            Console.ReadLine();

        }
        public static void MenuTrip()
        {
            Console.Clear();
        }
        public static void Back()
        {
            Console.WriteLine("Press b to back to the menu");
            BackCheck();
            
        }
        public static void BackCheck()
        {
            string b;
            b = Console.ReadLine();
            if(b =="b")
            {
                Console.Clear();
                MenuStart();
                SelectMenu();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Menu.BackCheck();
            }
        }
        public static int MenuCheckInputInt()
        {
            int result = 0;
            string menuInput = Console.ReadLine();
            if (menuInput == "1" || menuInput == "2" || menuInput == "3" || menuInput == "4" || menuInput == "5")
            {
                result = Convert.ToInt32(menuInput);
                return result;
            }
            else
            {
                Console.WriteLine("Wrong Input!");
                Menu.MenuCheckInputInt();

            }
            return result;


        }
        public static void MenuCity()
        {
            Story.Story2();
            Console.WriteLine("s-shop");
            Console.WriteLine("t-trip");
            Console.WriteLine("b-back");
            MenuCitySelect();
            Console.ReadLine();
        }
        public static void MenuCitySelect()
        {
            MenuCityCheck();
        }
        public static void MenuCityCheck()
        {
            string cityInput = Console.ReadLine();
            if(cityInput == "s")
            {
                Shop.ShopInTown();
                Shop.ShopInfo();
                Menu.ShopCityMenu();
            }
            else if(cityInput == "t")
            {
                Trips.TripSelction();
            }
            else if(cityInput == "b")
            {
                Console.Clear();
                MenuStart();
                SelectMenu();
            }            
            else
            {
                Console.WriteLine("Wrong Input");
                MenuCityCheck();
            }
        }
        public static void ShopCityMenu()
        {
            
            Console.WriteLine("u-upgrade");
            Console.WriteLine("s-sword");
            Console.WriteLine("m-medicines");
            Console.WriteLine("b-back");

            string ShopChoice = Console.ReadLine();
            
            
                if (ShopChoice == "s")
                {
                    Shop.SwordOfDevine();
                    Character.StatsInfo();
                    Console.ReadLine();
                    Console.Clear();
                    Shop.ShopInTown();
                    Shop.ShopInfo();
                    ShopCityMenu();
                }
                else if (ShopChoice == "u")
                {
                    Shop.Upgrade_1();
                    Character.StatsInfo();
                    Console.ReadLine();
                    Console.Clear();
                    Shop.ShopInTown();
                    Shop.ShopInfo();
                    ShopCityMenu();
                }
                else if(ShopChoice== "m")
                {
                    Shop.Medicines();
                    Character.StatsInfo();
                    Console.ReadLine();
                    Console.Clear();
                    Shop.ShopInTown();
                    Shop.ShopInfo();
                    ShopCityMenu();
                }
                else if (ShopChoice == "b")
                {
                    Console.Clear();
                    Console.WriteLine("Stuttgart");
                    Menu.MenuCity();

                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                    ShopCityMenu();
                }
            
        }
        /*public string Name
        {
            get
            {
                name = Console.ReadLine();
                Console.WriteLine("Hello " + name + "!");
                return name;
            }
            set
            {
                name = "Random Name";
            }
        }*/
    }
}
