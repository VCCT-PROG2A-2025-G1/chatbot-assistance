using System;

namespace ChatBot
{
    internal class SpywareAttacks
    {
        public static void Run(string username)
        {
            Console.WriteLine($"\nCHATTY BOT:\nHey {username}, have you ever heard of Spyware attacks? (yes/no): ");
            Console.WriteLine($"{username?.ToUpper()}:");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nAlright! Here's a summary for you:");
                Console.WriteLine("Spyware is a malicious software that secretly collects your personal info and sends it to third parties without your permission.");
                Console.WriteLine("It can track your internet habits, steal your login info, or even record what you type.");
            }
            else
            {
                Console.WriteLine($"\nCHATTY BOT:\nAwesome {username}, this knowledge helps you stay safer online!");
            }

            Console.WriteLine($"\nCHATTY BOT:\nWould you like a fun fact about spyware? (yes/no): ");
            Console.WriteLine($"{username?.ToUpper()}:");
            string factAnswer = Console.ReadLine()?.ToLower();

            if (factAnswer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nFun Fact: Over 90% of computers are infected with some type of spyware, adware, or virus. Wild, right?");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nCool, hope this info was helpful!");
            } 
            
        }
    }
}
