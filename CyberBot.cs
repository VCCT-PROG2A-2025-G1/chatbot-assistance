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

            Console.Clear();

            // Run topic modules
            SpywareAttacks.Run(UserProfile.Name);
            PhishingAttacks.Run(UserProfile.Name);
            SafeBrowsing.Run(UserProfile.Name);

            Console.WriteLine($"\nCHATTY BOT:\nThat’s all for now, {UserProfile.Name}. Stay safe online and keep learning more about {UserProfile.FavoriteTopic}!");
        }

        public static void invalidInput(string input)
        {
            if (input != "yes" && input != "no")
            {
                Console.WriteLine("\nCHATTY BOT:\nHmm, I didn’t get that. Just say 'yes' or 'no'.");
            }
        }
    }
}
