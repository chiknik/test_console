using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a notification title:");
        string inputText = Console.ReadLine();

        // Define the notification channels
        string[] notificationChannels = { "BE", "FE", "QA", "Urgent" };

        // Use regular expression to match tags within square brackets
        MatchCollection matches = Regex.Matches(inputText, @"\[([^\]]+)\]");

        // Create a HashSet to store unique notification channels
        HashSet<string> channels = new HashSet<string>();

        // Iterate through matches and add valid channels to the HashSet
        foreach (Match match in matches)
        {
            string channel = match.Groups[1].Value;
            if (notificationChannels.Contains(channel))
            {
                channels.Add(channel);
            }
        }

        // Build the output string
        string output = "Receive channels: " + string.Join(", ", channels);

        // Display the final output
        Console.WriteLine(output);
    }
}
