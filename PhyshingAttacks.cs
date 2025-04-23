using System;

namespace ChatBot
{
    internal class PhyshingAttacks
    {
        public static void Run(String username)
        {
            Console.WriteLine("\nCHATTY BOT:\nLet’s talk about phishing! Have you ever clicked on a sketchy email link? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nOh no! Phishing can trick you into giving up personal info like passwords or credit card details.");
                Console.ReadLine();
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nGreat! Always check for bad grammar or weird email addresses before clicking anything.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nHmm... I didn’t quite get that.");
                Console.ReadLine();
            }
        }
    }
}
