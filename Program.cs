using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            CyberBot.StartChat();
        }
    }
}
