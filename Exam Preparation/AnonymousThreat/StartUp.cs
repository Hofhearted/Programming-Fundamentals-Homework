using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AnonymousThreat
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string inputLine;
            List<string> output = new List<string>();
            StringBuilder sb = new StringBuilder();
            while ((inputLine = Console.ReadLine()) != "3:1")
            {
                string[] commands = inputLine.Split(' ');
                if (commands[0] == "merge")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    for (int i = start; i <= end; i++)
                    {
                        output.Add(input[i]);
                    };
                    var list = output.Distinct();
                    foreach (var item in output)
                    {
                        Console.Write(item);
                    }

                    Console.WriteLine();
                }
            }

            }
        }
    }

