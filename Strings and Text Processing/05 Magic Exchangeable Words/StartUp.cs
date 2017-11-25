using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string[] lineOfWords = Console.ReadLine().Split();
        Dictionary<char, char> splittedWords = new Dictionary<char, char>();
        bool checkifexchangeable = false;
        char[] firstWord = lineOfWords[0].ToCharArray();
        char[] secondWord = lineOfWords[1].ToCharArray();

        for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
        {
            if (!splittedWords.ContainsKey(firstWord[i]))
            {
                if (!splittedWords.ContainsValue(secondWord[i]))
                {
                    splittedWords.Add(firstWord[i], secondWord[i]);
                }
            }
            else if (splittedWords[firstWord[i]] != secondWord[i])
            {
                checkifexchangeable = true;
                Console.WriteLine("false");
                break;
            }
        }

        if (checkifexchangeable == false)
        {
            if (firstWord.Length > secondWord.Length)
            {
                for (int f = secondWord.Length; f < firstWord.Length; f++)
                {
                    if (!splittedWords.ContainsKey(firstWord[f]))
                    {
                        checkifexchangeable = true;
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
            else
            {
                for (int k = firstWord.Length; k < secondWord.Length; k++)
                {
                    if (!splittedWords.ContainsValue(secondWord[k]))
                    {
                        checkifexchangeable = true;
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
        }

        if (checkifexchangeable == false)
        {
            Console.WriteLine("true");
        }
    }
}