using System;

namespace ChatBot
{
    internal class CyberBot
    {
        public static void StartChat()
        {

            Console.WriteLine("\nAI:\nHi there and welcome. What is your name ?");
            Console.WriteLine("\nUSER:");
            string username = Console.ReadLine();// read user input

            // capitalise first character of string 'username'
            // make the rest of the string 'username' lowercase
            username = char.ToUpper(username[0]) + username.Substring(1).ToLower();

            invalidInput(username);// validate user input

            Console.WriteLine("\nAI:\nHow are you doing " + username + "?");
            Console.WriteLine("\n"+username?.ToUpper() + ":");
            string answer = Console.ReadLine();// read user input

            invalidInput(answer);

            // if user types keywords like 'bad', 'not good', 'not okay
            if (answer.ToLower().Contains("bad") || answer.ToLower().Contains("not good") || answer.ToLower().Contains("not okay") || answer.ToLower().Contains("not fine"))
            {
                // print the following
                Console.WriteLine("\nAI:\nOh no! I am sorry. I'd advise you seek professional help.");
                Console.ReadLine();// prevents application from closing
            }
            else if (answer.ToLower().Contains("good") || answer.ToLower().Contains("okay") || answer.ToLower().Contains("well") || answer.ToLower().Contains("Fine"))
            {
                Console.WriteLine("\nCHATTY BOT:\nI'm happy to hear that " + username + ". My name is Chatty Bot. \nLet's chat about CyberSecurity.\nPick a topic below by typing out the number:");

                Console.WriteLine("\n1. Spyware attacks");
                Console.WriteLine("2. Password Safety");
                Console.WriteLine("3. Phishing Attakcs");
                Console.WriteLine("4. Safe Browsing");

                Console.WriteLine("\n"+username+":");

                string input = Console.ReadLine();// take user input

                invalidInput(input);

                switch (input)
                {
                    case "1":// if user types 1, run SpywareAttacks
                        SpywareAttacks.Run(username);
                        break;// program exits once SpywareAttacks is finished
                    case "2":
                        PasswordSafety.Run(username);
                        break;
                    case "3":
                        PhyshingAttacks.Run(username);
                        break;
                    case "4":
                        SafeBrowsing.Run(username);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Restarting...\n");
                        StartChat();// restarts the whole program
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nAI:\nHmmmm... I can't seem to understand your prompt.");
                Console.ReadLine();
            }
        }

        // function for validating user input
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
