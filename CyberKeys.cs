using System;
using System.Collections.Generic;
/// part 2 
namespace ChatBot
{
    internal class CyberKeywordHelper
    {
        /// <summary>
        /// Dictionary of keywords and their assosiated response tips
        /// </summary>
        /// -----------------------------------------------------------------------------------------------------------------------------------------
        private static readonly Dictionary<string, string> KeywordTips = new Dictionary<string, string>
        {
            { "password", "Use strong, unique passwords for each account, and consider using a password manager." },
            { "scam", "Avoid clicking on suspicious links or giving out personal info. If it looks too good to be true, it probably is!" },
            { "phishing", "Phishing emails often urge urgent action. Always double-check the sender and don’t click unknown links." },
            { "privacy", "Review app permissions and avoid oversharing personal info online." },
            { "malware", "Install antivirus software and avoid downloading files from unknown sources." },
        };
        private static readonly Dictionary<string, List<string>> RandomTips = new Dictionary<string, List<string>>()
        {
            { "phishing", new List<string>
                {
                    " Avoid clicking suspicious links—hover to check the URL.",
                    " Phishing scams often create urgency—take your time and verify.",
                    " Look for slight spelling errors in sender addresses."
                }
            },
            { "malware", new List<string>
                {
                    " Install antivirus software and update it regularly.",
                    " Don’t download attachments from unknown sources.",
                    " Keep your system updated to patch security flaws."
                }
            }
        };

        public static void HandleInput(string input)
        {
            string loweredInput = input.ToLower();

            // Method to Check for random tip keywords
            foreach (var topic in RandomTips.Keys)
            {
                if (loweredInput.Contains(topic))
                {
                    GiveRandomTip(topic);
                    return;
                }
            }

            // Method to Check for static tips
            foreach (var keyword in KeywordTips.Keys)
            {
                if (loweredInput.Contains(keyword))
                {
                    Console.WriteLine($"\nCHATTY BOT:\n{KeywordTips[keyword]}");
                    return;
                }
            }

            // Method If there is no match
            Console.WriteLine("\nCHATTY BOT:\nI didn’t quite catch that. Try asking about passwords, scams, privacy, phishing or malware.");
        }

        private static void GiveRandomTip(string topic)
        {
            var tips = RandomTips[topic];
            Random rnd = new Random();
            int index = rnd.Next(tips.Count);
            Console.WriteLine($"\nCHATTY BOT:\n{tips[index]}");
        }
    }
}
