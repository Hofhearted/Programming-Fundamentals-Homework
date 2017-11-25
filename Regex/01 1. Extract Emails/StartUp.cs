using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
