using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace D_FixEmails
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string[] domains = { ".us", ".uk" };
            while (name != null && !name.Equals("stop"))
            {
                string email = Console.ReadLine();
                phonebook.Add(name, email);
                name = Console.ReadLine();
            }
            RemoveEmailsByDomain(phonebook, domains);
            foreach (var item in phonebook)
            {

                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}\n");
            }
        }

        private static void RemoveEmailsByDomain(Dictionary<string, string> phonebook, string[] domains)
        {
            foreach (var domain in domains)
            {
                var filtredEmails = phonebook.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (var userEntry in filtredEmails)
                {
                    phonebook.Remove(userEntry.Key);
                }
            }
        }
    }
}