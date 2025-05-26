using System;
public static class SentimentAnalyzer
{
    //------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// Start/
    /// </summary>
    public static string DetectSentiment(string input)
    {
        input = input.ToLower();
        if (input.Contains("worried") || input.Contains("scared") || input.Contains("nervous"))
            return "worried";
        if (input.Contains("curious") || input.Contains("interested"))
            return "curious";
        if (input.Contains("frustrated") || input.Contains("confused"))
            return "frustrated";

        return "neutral";
    }

    public static void RespondToSentiment(string sentiment)
    {
        switch (sentiment)
        {
            case "worried":
                Console.WriteLine("CHATTY BOT:\nIt's completely understandable to feel that way. Scammers can be very convincing. Let me share some tips to help you stay safe.");
                break;
            case "curious":
                Console.WriteLine("CHATTY BOT:\nCuriosity is a great start! Let’s dive into some cool cybersecurity facts.");
                break;
            case "frustrated":
                Console.WriteLine("CHATTY BOT:\nI know it can be overwhelming. You're not alone—let’s break it down together.");
                break;
            default:
                Console.WriteLine("CHATTY BOT:\nThanks for sharing! Let's continue.");
                break;
        }
    }
}

public static class InputHelper
{
    public static string GetValidResponse(string prompt, List<string> validOptions)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine()?.ToLower();

        while (!validOptions.Contains(input))
        {
            Console.WriteLine("CHATTY BOT:\nI'm not sure I understand. Please choose a valid option:");
            input = Console.ReadLine()?.ToLower();
        }

        return input;
    }
}
