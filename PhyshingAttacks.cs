using System;

namespace ChatBot
{
    internal class PhyshingAttacks
    {
        public static void Run()
        {
            Console.WriteLine("\nCHATTY BOT:\nLet’s talk about phishing! Have you ever clicked on a sketchy email link? (yes/no): ");
            Console.WriteLine("YOU:");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nOh no! Phishing can trick you into giving up personal info like passwords or credit card details.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nGreat! Always check for bad grammar or weird email addresses before clicking anything.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nHmm... I didn’t quite get that. Remember: Be cautious online!");
            }
        }
    }
}
