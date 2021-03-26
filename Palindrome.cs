using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromy
{
    class Palindrome
    {
        public static void PalindromeCheck(string wordToCheck)
        {
            wordToCheck = wordToCheck.ToLower();
            wordToCheck = wordToCheck.Replace(" ", "");
            string wordReverse = "";
            for(int i = wordToCheck.Length - 1; i >= 0; i--)
            {
                wordReverse = wordReverse + wordToCheck[i];
            }            
            Console.WriteLine(wordReverse);
            if(wordReverse == wordToCheck)
            {
                Console.WriteLine("The word is palindrome");
            }
            else
            {
                Console.WriteLine("The word isn't palindrome");
            }

        }
        public static void PalindromeExamples()
        {
            Console.WriteLine("Palindromes: ");
            Console.WriteLine(" redivider, deified, civic, radar, level");
        }
    }
}
