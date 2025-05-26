using System;

namespace ChatBot
{
    public class ChatBot
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot!");
            while (true)
            {
                Console.Write("\nAsk me a question or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid question.");
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string userInput)
        {
            if (userInput.ToLower().Contains("phishing"))
                Console.WriteLine("Phishing is a scam where attackers trick you into giving up personal info.");
            else if (userInput.ToLower().Contains("password"))
                Console.WriteLine("Use long, unique passwords and a password manager.");
            else if (userInput.ToLower().Contains("safe browsing"))
                Console.WriteLine("Always check URLs and avoid clicking unknown links.");
            else if (userInput.ToLower().Contains("2fa"))
                Console.WriteLine("2FA adds an extra layer of security to your accounts.");
            else
                Console.WriteLine("I'm still learning! Try asking about phishing, passwords, 2FA, or safe browsing.");
        }
    }
}
