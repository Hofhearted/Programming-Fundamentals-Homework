using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace B_PhonebookUpgrade
{
    internal class Program
    {
        private static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                var entry = Console.ReadLine()?.Split(' ').ToArray();
                var command = entry?[0];
                if (command == "END")
                {
                    break;
                }
                var name = "";
                var phone = "";

                Debug.Assert(entry != null, nameof(entry) + " != null");
                if (entry.Length >= 2)
                {
                    name = entry[1];
                }

                if (entry.Length == 3)
                {
                    phone = entry[2];
                }

                switch (command)
                {
                    case "A":
                        if (phonebook.ContainsKey(name) && !phonebook.ContainsValue(phone))
                        {
                            phonebook.Remove(name);
                            phonebook.Add(name, phone);
                        }
                        else if (!phonebook.ContainsKey(name) && !phonebook.ContainsValue(phone))
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        else if (phonebook.ContainsKey(name))
                        {
                            foreach (var item in phonebook)
                            {
                                if (item.Key == name)
                                {
                                    Console.WriteLine($"{item.Key} -> {item.Value}");
                                }
                            }
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                }

            }
        }
    }
}