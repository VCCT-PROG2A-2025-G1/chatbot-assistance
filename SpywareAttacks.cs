using ChatBot;
// St10082707 Mohlao Makhale
// References: 
//https://www.fortinet.com/resources/cyberglossary/spyware
//https://renogeek.com/7-facts-about-spyware/

using System;

namespace ChatBot
{
    /// <summary>
    /// Provides chatbot dialogue and education about spyware attacks.
    /// </summary>
    internal class SpywareAttacks
    {
        /// <summary>
        /// Starts the spyware conversation with the user.
        /// </summary>
        /// <param name="username">The user's name.</param>
        public static void Run(string username)
        {
            Console.WriteLine($"\nCHATTY BOT:\nHey {username}, have you ever heard of Spyware attacks? (yes/no): ");
            Console.WriteLine($"\n{username?.ToUpper()}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

            if (answer == "yes")
            {
                Console.WriteLine($"\nCHATTY BOT:\nLooks like you're well informed {username}!");
                Console.WriteLine("press Enter to continue");  // why isnt this showing when i run
            }
            else if (answer == "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nSpyware is malicious software that secretly collects your personal info and sends it to third parties without permission.");
                Console.WriteLine("It can track your habits, steal login info, and even record your keystrokes.");
            }
            else
            {
                Console.WriteLine($"\nCHATTY BOT:\nLet’s still go over the basics to help you stay safer online!");
            }

            // Follow-up: Want a tip?
            Console.WriteLine($"\nCHATTY BOT:\nWould you like a safety tip for avoiding spyware? (yes/no): ");
            Console.WriteLine($"\n{username?.ToUpper()}:");
            string tip = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(tip);

            if (tip == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nAlways install reputable antivirus software and avoid downloading unknown files.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nNo problem! Just stay cautious with unknown links and downloads.");
            }

            // Fun fact
            Console.WriteLine($"\nCHATTY BOT:\nWant to hear a fun fact about spyware? (yes/no): ");
            Console.WriteLine($"\n{username?.ToUpper()}:");
            string factAnswer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(factAnswer);

            if (factAnswer == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nOver 90% of computers have been exposed to some kind of spyware at some point.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nAlright! Glad we had this chat.");
            }
        }
    }
}
