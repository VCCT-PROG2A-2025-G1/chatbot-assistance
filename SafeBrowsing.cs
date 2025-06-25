//part 2
// References:
//https://brave.com/glossary/safe-browsing/
using ChatBot;
using System;

namespace ChatBot
{
    /// <summary>
    /// Provides chatbot dialogue and guidance on safe web browsing practices.
    /// </summary>
    internal class SafeBrowsing
    {
        /// <summary>
        /// Starts the safe browsing conversation.
        /// </summary>
        /// <param name="username">The user's name.</param>
        public static void Run(string username)
        {
            Console.WriteLine("\nCHATTY BOT:\nAre you in the habit of checking if websites are secure before entering info? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nThat’s awesome! Always check for ‘https’ and the padlock icon in the browser address bar.");
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nIt's super important! Secure sites protect your data from cybercriminals.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nNo problem, let’s go through some best practices together.");
            }

            // Offer a tip
            Console.WriteLine("\nCHATTY BOT:\nWould you like a tip for safe browsing? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string tip = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(tip);

            if (tip == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nAvoid clicking on pop-ups or ads—they often lead to unsafe websites.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nAlright. Just remember to browse mindfully and use trusted sources.");
            }

            // Ask if they want to learn about private/incognito mode
            Console.WriteLine("\nCHATTY BOT:\nWould you like to learn about incognito browsing? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string incognito = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(incognito);

            if (incognito == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nIncognito mode prevents your browser from saving your history, cookies, and site data.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nCool! Just know that incognito isn't 100% anonymous—it mainly hides activity from other users of your device.");
            }
        }
    }
}
