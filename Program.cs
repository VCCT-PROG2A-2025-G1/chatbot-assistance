using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("===========================================");
            Console.WriteLine("    CYBERSECURITY AWARENESS CHATBOT v1.0  ");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("          [###########]");
            Console.WriteLine("         [#  ^     ^  #]");
            Console.WriteLine("         [#    ---    #]   <-- Hello! I'm your");
            Console.WriteLine("         [#   \\___/   #]       CyberSecureBot!");
            Console.WriteLine("          [###########]");
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

            // Initialize the SoundPlayer with the path to the .wav file
            string filePath = @"C:\Users\chloe\Source\Repos\chatbot-assistance\audio-greeting.wav"; // File in the root of the project
            SoundPlayer player = new SoundPlayer(filePath);
            player.Load();// Load the file
            player.Play();// Play the audio

            CyberBot.StartChat();//start application
        }
    }
}
