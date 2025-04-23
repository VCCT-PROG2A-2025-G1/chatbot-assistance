using System;

namespace ChatBot
{
    internal class PasswordSafety
    {
        public static void Run(String username)
        {
            Console.WriteLine("\nCHATTY BOT:\nLet’s talk passwords! Do you reuse the same password on multiple websites? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nYikes! That’s risky. If one site is hacked, all your accounts could be exposed.");
                Console.ReadLine();
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nNice one! Want to hear a fun fact? (yes/no): ");
                Console.WriteLine($"\n{username}:");
                string funFact = Console.ReadLine()?.ToLower();
                CyberBot.invalidInput(funFact);

                if (funFact == "yes")
                {
                    Console.WriteLine("\nCHATTY BOT:\nAn 8-character password using upper & lower-case letters has over 53 trillion billion combos!");
                    Console.WriteLine("Tip: Use a password manager or write them down securely.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nCHATTY BOT:\nCool, glad you’re already on top of things!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nI didn’t catch that... but let’s move on!");
                Console.ReadLine();
            }
        }
    }
}
