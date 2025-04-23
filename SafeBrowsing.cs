using System;

namespace ChatBot
{
    internal class SafeBrowsing
    {
        public static void Run(String username)
        {
            Console.WriteLine("\nCHATTY BOT:\nAre you in the habit of checking if websites are secure before entering info? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nThat’s awesome! Always check for ‘https’ and the padlock icon in the browser address bar.");
                Console.ReadLine();
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nIt’s super important! Secure sites keep your data safe from hackers.");
                Console.WriteLine("\nWould you like a browsing safety tip? (yes/no): ");
                Console.WriteLine($"\n{username}:");
                string tip = Console.ReadLine()?.ToLower();
                CyberBot.invalidInput(tip);

                if (tip == "yes")
                {
                    Console.WriteLine("\nCHATTY BOT:\nAvoid clicking pop-ups or shady ads—they often lead to unsafe websites.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nCHATTY BOT:\nNo worries! Just remember to stay alert online.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nOops! I didn’t catch that.");
                Console.ReadLine();
            }
        }
    }
}
