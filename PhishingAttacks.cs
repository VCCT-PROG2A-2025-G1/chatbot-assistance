
// References:
// 
using System;
using ChatBot;
namespace ChatBot
{
    /// <summary>
    /// Provides chatbot dialogue and warnings about phishing attacks.
    /// </summary>
    internal class PhishingAttacks
    {
        /// <summary>
        /// Starts the phishing awareness conversation with the user.
        /// </summary>
        /// <param name="username">The user's name.</param>
        public static void Run(string username)
        {
            Console.WriteLine("\nCHATTY BOT:\nLet’s talk about phishing! Have you ever clicked on a sketchy email link? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string answer = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(answer);

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
                Console.WriteLine("\nCHATTY BOT:\nNot sure? That's okay—let me explain it briefly.");
                Console.WriteLine("Phishing is a cyber attack where criminals pretend to be trustworthy sources to trick you.");
            }

            // Follow-up
            Console.WriteLine("\nCHATTY BOT:\nWould you like to learn how to spot a phishing email? (yes/no): ");
            Console.WriteLine($"\n{username}:");
            string detail = Console.ReadLine()?.ToLower();
            CyberBot.invalidInput(detail);

            if (detail == "yes")
            {
                Console.WriteLine("\nCHATTY BOT:\nLook for suspicious email addresses, urgent language, or unexpected attachments.");
            }
            else
            {
                Console.WriteLine("\nCHATTY BOT:\nNo worries! Just be cautious and report anything suspicious.");
            }
        }
    }
}
