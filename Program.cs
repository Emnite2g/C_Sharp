using System;

namespace Palindromy
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1.Check if a word is a palindrome");
            Console.WriteLine("2.Palindrome Examples");
            Console.WriteLine("3.Exit");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        Console.Write("Type word to check: ");
                        string isPalindrome = Console.ReadLine();
                        Palindrome.PalindromeCheck(isPalindrome);
                        break;
                    case "2":
                        Palindrome.PalindromeExamples();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
                Console.Clear();          
                        
            }
        }
    }
}
