using System;

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

            // Ask for sentiment-based intro
            Console.WriteLine($"\nCHATTY BOT:\nBefore we begin, how are you feeling about cybersecurity today?");
            Console.Write($"\n{UserProfile.Name}: ");
            string moodInput = Console.ReadLine();
            string detectedSentiment = SentimentAnalyzer.DetectSentiment(moodInput);
            SentimentAnalyzer.RespondToSentiment(detectedSentiment);

            // Enter question-and-answer loop with ChatBot
            ChatBot bot = new ChatBot();
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
                    break;
                }

                bot.Respond(input); // Now accessible!
            }

            // Clear screen and run educational modules
            Console.Clear();
            SpywareAttacks.Run(UserProfile.Name);
            PhishingAttacks.Run(UserProfile.Name);
            SafeBrowsing.Run(UserProfile.Name);

            Console.WriteLine($"\nCHATTY BOT:\nThat’s all for now, {UserProfile.Name}. Stay safe online and keep learning more about {UserProfile.FavoriteTopic}!");
        }
    }
}
