using System;
using System.Text.RegularExpressions;

namespace AnonymosVox
{
    public class StartUp
    {
        public static void Main()
        {
            string encodedText = Console.ReadLine();
            string placeholder = Console.ReadLine();

            string patternText = @"([A-Za-z]+)(\w+)(\1)";
            string patternPlaceholder = @"{(\w+)}";

            Regex regexText = new Regex(patternText);
            Regex regexPlaceholder = new Regex(patternPlaceholder);

            MatchCollection encoded = regexText.Matches(encodedText);
            MatchCollection placeholdered = regexPlaceholder.Matches(placeholder);

            string encodedMatch = null;
            string placeholderedMatch = null;

            foreach (Match match in encoded)
            {
                encodedMatch = match.Groups[2].ToString();
            }

            foreach (Match placematch in placeholdered)
            {
                placeholderedMatch = placematch.Groups[1].ToString();
            }

            string end = encodedText.Replace(encodedMatch, placeholderedMatch);
            Console.WriteLine(end);
        }
    }
}
