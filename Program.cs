using System;
using System.Media;
//ST10082707
// Mohlao Makhale
// BCAD2 GR 1
namespace ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console color for branding
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // Display welcome ASCII art and safety tips
            Console.WriteLine("===========================================");
            Console.WriteLine("    CYBERSECURITY AWARENESS CHATBOT v1.0  ");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("         [###########]");
            Console.WriteLine("         [#  ^     ^  #]");
            Console.WriteLine("         [#    ---    #]   <-- Hello! I'm your");
            Console.WriteLine("         [#   \\___/   #]       CyberSecureBot!");
            Console.WriteLine("         [###########]");
            Console.WriteLine("             |||||");
            Console.WriteLine("        _____|||||_____");
            Console.WriteLine("       |               |");
            Console.WriteLine("       |   Stay Safe   |");
            Console.WriteLine("       |   Online!     |");
            Console.WriteLine("       |_______________|");
            Console.WriteLine();
            Console.WriteLine(" Tips: ");
            Console.WriteLine(" - Don't click unknown links");
            Console.WriteLine(" - Use strong passwords");
            Console.WriteLine(" - Keep your software updated");
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.ResetColor();

            try
            {
                string filePath = @"C:\Users\chloe\Source\Repos\chatbot-assistance\audio-greeting.wav";
                SoundPlayer player = new SoundPlayer(filePath);
                player.Load();
                player.Play();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("CHATTY BOT:\nAudio greeting file not found. Skipping sound...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CHATTY BOT:\nAn error occurred while playing the greeting: {ex.Message}");
            }
            CyberBot.StartChat();

        }
    }
}
