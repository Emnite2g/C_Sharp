using System;
using System.Collections.Generic;
using System.Text;

namespace Game2D
{
    class Story
    {
        public static void Story1()
        {
            Console.Clear();
            
            //Console.WriteLine("Hello " + Menu.name + "!");
            Console.WriteLine("You are the choosen one to defeat King Valson but first you need to take some expierience and find items, that help you defeat the King. Good Luck!");
            Console.ReadLine();
        }
        public static void Author()
        {
            Console.Clear();
            Console.WriteLine("Created by Krzysztof Soja");
        }
        public static void Story2()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Stuttgart. You can find some upgrades and new stuff in a shop.");

        }
        public static void Trip1()
        {
            Console.WriteLine("We have got a problem with one of the knihgts.");
            Console.WriteLine("He rebeled against the law and he started to torment residents.");
            Console.WriteLine("Solve this problem.");
        }
        public static void Trip2()
        {
            Console.WriteLine("Thiefs have stolen the holy scroll.");
            Console.WriteLine("Your's mission is to restore this artifact.");
            Console.WriteLine("We hope that you can help us.");           

        }
        public static void Trip3()
        {
            Console.WriteLine("Your's friend Alan has been captured by bandits.");
            Console.WriteLine("We know where they are going to transport him.");
            Console.WriteLine("Let's free him.");
        }
        public static void Trip4()
        {
            Console.WriteLine("To find out where King is located, we must visit one of his mine.");
            Console.WriteLine("We will destroy mineshaft and they will probably send message to the King about it.");
            Console.WriteLine("We are going to track commissionare and that's how we get to know where is the King.");
        }
        public static void Trip5()
        {
            Console.WriteLine("We got information where we can find the King.");
            Console.WriteLine("Let's visit him but first we need to handle with his guards");
            Console.WriteLine("Good Luck!");
        }
    }
}
