using System;
using System.Collections.Generic;
using System.IO;

namespace C_AMinerTask
{
    public class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, int> mats = new Dictionary<string, int>();

            while (true)
            {
                string material = Console.ReadLine();

                int quantity;
                if (material == "stop")
                {
                    PrintSortedResults(mats);
                    break;
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                }

                if (mats.ContainsKey(material ?? throw new InvalidOperationException()))
                {
                    mats[material] += quantity;
                }
                else
                {
                    mats.Add(material, quantity);
                }

            }
        }

        private static void PrintSortedResults(Dictionary<string, int> mats)
        {
            foreach (KeyValuePair<string, int> materials in mats)
            {

                File.AppendAllText("output.txt", $"{materials.Key} -> {materials.Value}\n");
            }

        }
    }
}