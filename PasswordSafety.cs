// References:
// https://edu.gcfglobal.org/en/techsavvy/password-tips/1/

using ChatBot;
using System;

namespace ChatBot
{
    internal class PasswordSafety
    {
        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Main method for interacting with user about password safety with natural follow-up flow.
        /// </summary>
        /// <param name="username">The current user’s name</param>
        //------------------------------------------------------------------------------------------------------------------------//
        public static void Run(string username)
        {
            while (true)
            {
                Console.WriteLine("\nCHATTY BOT:\nLet’s talk passwords! Do you reuse the same password on multiple websites? (yes/no)");
                Console.Write($"\n{username}: ");//personified responses
                string answer = Console.ReadLine()?.ToLower();
                CyberBot.invalidInput(answer); // Input validation method

                if (answer == "yes")
                {
                    Console.WriteLine("\nCHATTY BOT:\nThat’s risky. If one website is hacked, all your accounts could be compromised.");
                    AskFollowUp(username);
                    break;
                }
                else if (answer == "no")
                {
                    Console.WriteLine("\nCHATTY BOT:\nGreat job! Would you like to hear a password safety tip? (yes/no)");
                    Console.Write($"\n{username}: ");
                    string tipAnswer = Console.ReadLine()?.ToLower();
                    CyberBot.invalidInput(tipAnswer);

                    if (tipAnswer == "yes")
                    {
                        Console.WriteLine("\nCHATTY BOT:\nStrong passwords should include numbers, symbols, and both uppercase and lowercase letters.");
                    }
                    else
                    {
                        Console.WriteLine("\nCHATTY BOT:\nNo problem, we can skip the tip!");
                    }
                    // strong conversation structures implemented
                    AskFollowUp(username);
                    break;
                }
                else
                {
                    Console.WriteLine("\nCHATTY BOT:\nOops! Please type only 'yes' or 'no'.");
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Method to handle follow-up questions and deeper discussion flow.
        /// </summary>
        /// <param name="username">Current user’s name</param>
        //------------------------------------------------------------------------------------------------------------------------//
        private static void AskFollowUp(string username)
        {
            while (true)
            {
                Console.WriteLine("\nCHATTY BOT:\nWould you like to:\n1. Ask a follow-up question\n2. Learn more tips\n3. Return to main menu");
                Console.Write($"\n{username}: ");
                string input = Console.ReadLine()?.ToLower();
                CyberBot.invalidInput(input);

                if (input == "1")
                {
                    Console.WriteLine("\nCHATTY BOT:\nGo ahead, what's your question?");
                    Console.Write($"\n{username}: ");
                    string followUp = Console.ReadLine();
                    CyberBot.invalidInput(followUp);

                    Console.WriteLine("\nCHATTY BOT:\nThat’s a good question. Here's a tip: Always enable two-factor authentication (2FA) for extra security.");
                }
                else if (input == "2")
                {
                    Console.WriteLine("\nCHATTY BOT:\nHere are some extra tips:");
                    Console.WriteLine("- Use unique passwords for different accounts.");
                    Console.WriteLine("- Avoid using personal info like your name or birthdate.");
                    Console.WriteLine("- Use a password manager to store your passwords safely.");
                }
                else if (input == "3")
                {
                    Console.WriteLine("\nCHATTY BOT:\nAlright, returning to the main menu...");
                    break;// returns back to the main menu
                }
                else
                {
                    Console.WriteLine("\nCHATTY BOT:\nPlease type 1, 2, or 3 to continue.");
                }
            }
        }
    }
}
