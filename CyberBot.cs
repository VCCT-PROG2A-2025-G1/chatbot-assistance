using System;
using System.Threading;

namespace ChatBot
{
    internal class CyberBot
    {
        public static void StartChat()
        {
            Console.WriteLine("CHATTY BOT:\nHi there! What's your name?");
            Console.Write("\nYou: ");
            UserProfile.Name = Console.ReadLine();

            Console.WriteLine($"\nCHATTY BOT:\nNice to meet you, {UserProfile.Name}! What's your favorite cybersecurity topic? (Spyware, Phishing, Safe Browsing)");
            Console.Write($"\n{UserProfile.Name}: ");
            UserProfile.FavoriteTopic = Console.ReadLine()?.ToLower();

            Console.WriteLine($"\nCHATTY BOT:\nAwesome! I’ll try to include some tips on {UserProfile.FavoriteTopic} later.");
            Thread.Sleep(800);

            // Ask for sentiment-based intro
            Console.WriteLine($"\nCHATTY BOT:\nBefore we begin, how are you feeling about cybersecurity today?");
            Console.Write($"\n{UserProfile.Name}: ");
            string moodInput = Console.ReadLine();
            string detectedSentiment = SentimentAnalyzer.DetectSentiment(moodInput);
            SentimentAnalyzer.RespondToSentiment(detectedSentiment);
            Thread.Sleep(800);

            // Begin question-and-answer loop
            Console.WriteLine($"\nCHATTY BOT:\nYou can now ask me anything about cybersecurity! Type 'next' when you're ready to move on.");
            while (true)
            {
                Console.Write($"\n{UserProfile.Name}: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("CHATTY BOT:\nPlease enter a valid question.");
                    continue;
                }

                if (input.ToLower() == "next")
                {
                    Console.WriteLine("CHATTY BOT:\nAlright! Let's go through a few short lessons.");
                    Thread.Sleep(800);
                    break;
                }

                CyberResponse.HandleInput(input);
                Thread.Sleep(800);
            }

            // Educational modules
            Console.Clear();
            SpywareAttacks.Run(UserProfile.Name);
            Thread.Sleep(800);
            PhishingAttacks.Run(UserProfile.Name);
            Thread.Sleep(800);
            SafeBrowsing.Run(UserProfile.Name);
            Thread.Sleep(800);

            Console.WriteLine($"\nCHATTY BOT:\nThat’s all for now, {UserProfile.Name}. Stay safe online and keep learning more about {UserProfile.FavoriteTopic}!");
        }

        /// <summary>
        /// Validates user input for blank or odd values.
        /// </summary>
        public static void invalidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("CHATTY BOT:\nOops! You didn’t enter anything. Please try again.");
                Thread.Sleep(500);
            }
            else if (input.Length < 2 && !char.IsLetterOrDigit(input[0]))
            {
                Console.WriteLine("CHATTY BOT:\nThat doesn't look like a valid answer.");
                Thread.Sleep(500);
            }
        }
    }
}
