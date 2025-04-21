using System;

namespace ChatBot
{
    internal class CyberBot
    {
        public static void StartChat()
        {

            Console.WriteLine("AI:\nHi there and welcome. What is your name ?");
            Console.WriteLine("");
            Console.WriteLine("USER:");
            string username = Console.ReadLine();

            invalidInput(username);

            Console.WriteLine("\nAI:\nHow are you doing " + username + "?");
            Console.WriteLine("");
            Console.WriteLine(username?.ToUpper() + ":");
            string answer = Console.ReadLine();

            invalidInput(answer);

            if (answer.ToLower().Contains("bad") || answer.ToLower().Contains("not good") || answer.ToLower().Contains("not okay"))
            {
                Console.WriteLine("\nAI:\nOh no! I am sorry. I'd advise you seek professional help.");
                Console.ReadLine();
            }
            else if (answer.ToLower().Contains("good") || answer.ToLower().Contains("okay"))
            {
                Console.WriteLine("\nCHATTY BOT:\nI'm happy to hear that " + username + ". My name is Chatty Bot. \nLet's chat about CyberSecurity.\nPick a topic below by typing out the number:");

                Console.WriteLine("\n1. Spyware attacks");
                Console.WriteLine("2. Password Safety");
                Console.WriteLine("3. Baiting attacks");
                Console.WriteLine("4. Phishing Attakcs");
                Console.WriteLine("\nYour choice: ");

                string input = Console.ReadLine();

                invalidInput(input);

                switch (input)
                {
                    case "1":
                        SpywareAttacks.Run(username);
                        break;

                    case "2":
                        PasswordSafety.Run();
                        break;
                    case "3":
                    /*BaitingAttacks.Run();
                    break;*/
                    case "4":
                        PhyshingAttacks.Run();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Restarting...\n");
                        StartChat();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nAI:\nHmmmm... I can't seem to understand your prompt.");
                Console.ReadLine();
            }
        }

        public static void invalidInput(string input)
        {
            if (input == null || input == " " || input == "" || input.Length == 0)
            {
                Console.WriteLine("\nAI:\nInvalid response provided. Goodbye...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }

}
