using System;
using System.Collections.Generic;

namespace A_Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] info = Console.ReadLine()?.Split();
            IDictionary<string, string> phoneBookDictionary = new Dictionary<string, string>();
            while (info != null && info[0] != "END")
            {
                if (info[0] == "A")
                {
                    if (phoneBookDictionary.ContainsKey(info[1]))
                    {
                        phoneBookDictionary.Remove(info[1]);
                    }
                    phoneBookDictionary.Add(info[1], info[2]);
                }
                else
                {
                    if (phoneBookDictionary.ContainsKey(info[1]))
                    {
                        Console.WriteLine("{0} -> {1}", info[1], phoneBookDictionary[info[1]]);
                    }
                    else if (info[0] == "S")
                    {
                        Console.WriteLine("Contact {0} does not exist.", info[1]);
                    }
                }
                info = Console.ReadLine()?.Split();
            }
        }
    }
}