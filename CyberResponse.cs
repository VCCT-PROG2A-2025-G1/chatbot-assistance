using System;
using System.Collections.Generic;

namespace ChatBot
{
    internal class CyberResponse
    {
        //------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Method to keep keywords and specific responses
        /// </summary>
        /// <param name="username">Current user’s name</param>
        //------------------------------------------------------------------------------------------------------------------------//

        private static readonly Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>()
        {
            {
                "password", new List<string>()
                {
                    "Tip: Never reuse the same password across sites!",
                    "Use a combination of letters, numbers, and symbols in your passwords.",
                    "Consider using a password manager to keep track of unique passwords."
                }
            },
            {
                "phishing", new List<string>()
                {
                    "Phishing emails often look real. Always verify links before clicking.",
                    "Never share your personal info via email. That's a red flag.",
                    "If in doubt, contact the organization directly — not through email links."
                }
            },
            {
                "privacy", new List<string>()
                {
                    "Review app permissions regularly to protect your privacy.",
                    "Always log out of public/shared computers.",
                    "Use private browsing when accessing sensitive sites in public."
                }
            },
            {
                "scam", new List<string>()
                {
                    "Scams often use urgency — take your time before responding.",
                    "Don’t trust calls or emails asking for your bank info.",
                    "Scammers often impersonate real companies — always double-check."
                }
            }
        };

        public static void HandleInput(string input)
        {
            input = input.ToLower();
            bool foundKeyword = false;

            foreach (var entry in keywordResponses)
            {
                if (input.Contains(entry.Key))
                {
                    foundKeyword = true;
                    List<string> responses = entry.Value;
                    Random rand = new Random();
                    int index = rand.Next(responses.Count);
                    Console.WriteLine($"\nCHATTY BOT:\n{responses[index]}");
                    break;
                }
            }

            if (!foundKeyword)
            {
                Console.WriteLine("\nCHATTY BOT:\nI didn’t quite catch that. Try asking about passwords, phishing, scams or privacy.");
            }
        }
    }
}
