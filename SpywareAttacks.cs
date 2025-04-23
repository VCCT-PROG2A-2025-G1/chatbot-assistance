using System;

namespace ChatBot
{
    internal class SpywareAttacks
    {
        public static void Run(string username)
        {
            Console.WriteLine($"\nCHATTY BOT:\nHey {username}, have you ever heard of Spyware attacks? (yes/no): ");
            Console.WriteLine($"\n{username?.ToUpper()}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine($"\nCHATTY BOT:\nLooks like you're well informed {username}!");
                Console.ReadLine();
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:");
                Console.WriteLine("\nSpyware is a malicious software that secretly collects your personal info and sends it to third parties without your permission.");
                Console.WriteLine("It does this by tracking your internet habits, stealing your login info, and recording your keystrokes.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\nCHATTY BOT:\nAwesome {username}, this knowledge helps you stay safer online!");
                Console.ReadLine();
            }

            Console.WriteLine($"\nCHATTY BOT:\nWould you like a fun fact about spyware? (yes/no): ");
            Console.WriteLine($"\n{username?.ToUpper()}:");
            string factAnswer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(factAnswer);

            if (factAnswer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nOver 90% of computers are infected with some type of spyware, adware, or virus.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nCool, hope this info was helpful!");
                Console.ReadLine();
            }
        }
    }
}
