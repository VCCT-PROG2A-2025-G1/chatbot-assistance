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
            // Hi my name is Chloe, and this is my first commit
            Console.WriteLine("Hi, I am VC chatbot. What is your name?");
            Console.WriteLine("");
            string username = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hello " + username+"! I hope you are well. How can I help you?");

            string text = Console.ReadLine();

            if (text.Contains("cybersecurity"))
            {
                Console.WriteLine("Cybersecurity is the staple of the online world.");
            }
            else {
                Console.WriteLine("Goodbye...");
            }
        }
    }
}
