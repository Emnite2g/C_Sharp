using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int secretNumber = r.Next(0, 100);
            int guess = 0;
            int guessLimit = 10;
            int guessCount = 1;
            

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Try: " + guessCount);
                    Console.Write("Guess a number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    continue;
                }
                                
                if(guess == secretNumber)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if(guess > secretNumber)
                {
                    Console.WriteLine("Too big number");
                    Console.ReadLine();
                    guessCount++;
                }else if (guess < secretNumber)
                {
                    Console.WriteLine("Too small number");
                    Console.ReadLine();
                    guessCount++;
                }
                if(guessCount > guessLimit )
                {
                    Console.Clear();
                    Console.WriteLine("You lose!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                
            }
        }
    }
}
