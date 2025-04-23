using System;

namespace ChatBot
{
    internal class SafeBrowsing
    {
        public static void Run()
        {
            Console.WriteLine("\nCHATTY BOT:\nAre you in the habit of checking if websites are secure before entering info? (yes/no): ");
            Console.WriteLine("YOU:");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nThat’s awesome! Always check for ‘https’ and the padlock icon in the browser address bar.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nIt’s super important! Secure sites keep your data safe from hackers.");
                Console.WriteLine("Would you like a browsing safety tip? (yes/no): ");
                Console.WriteLine("YOU:");
                string tip = Console.ReadLine()?.ToLower();

                if (tip == "yes")
                {
                    Console.WriteLine("\nCHATTY BOT:\nTip: Avoid clicking pop-ups or shady ads—they often lead to unsafe websites.");
                }
                else
                {
                    Console.WriteLine("\nCHATTY BOT:\nNo worries! Just remember to stay alert online.");
                }
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nOops! I didn’t catch that. Let’s move on.");
            }
        }
    }
}
