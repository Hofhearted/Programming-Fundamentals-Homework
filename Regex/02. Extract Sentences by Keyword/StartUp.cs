using System;
using System.Text.RegularExpressions;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = $@"\b{word}\b";
            foreach (var sentence in text)
            {
                Match match = Regex.Match(sentence, pattern);
                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
