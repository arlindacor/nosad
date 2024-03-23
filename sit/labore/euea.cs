using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class LinkItem
{
    public string Href;
    public string Text;

    public static List<LinkItem> Find(string file)
    {
        var list = new List<LinkItem>();

        // Read the content of the file
        string fileContent = File.ReadAllText(file);

        // Use regular expression to find all links in the file content
        var regex = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        foreach(Match match in regex.Matches(fileContent))
        {
            var linkItem = new LinkItem
            {
                Href = match.Value,
                Text = "" // You can modify this to extract the text of the link if available
            };

            list.Add(linkItem);
        }

        return list;
    }
}

// Usage example
class Program
{
    static void Main()
    {
        string filePath = @"path\to\your\file.txt";
        List<LinkItem> links = LinkItem.Find(filePath);

        // Display the links found in the file
        foreach(var link in links)
        {
            Console.WriteLine($"Link: {link.Href}");
        }
    }
}
