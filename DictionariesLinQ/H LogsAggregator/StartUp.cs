using System;
using System.Collections.Generic;
using System.Linq;

namespace H_LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (int i = 0; i < n; i++)
            {
                string commandLine = Console.ReadLine();

                ProcessRawData(commandLine, logs);
            }
            SortAndPrintData(logs);
        }

        private static void SortAndPrintData(Dictionary<string, Dictionary<string, int>> logs)
        {
            foreach (var user in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                int commaCounter = 0;
                foreach (var data in user.Value.OrderBy(x => x.Key))
                {
                    Console.Write($"{data.Key}");
                    if (commaCounter < user.Value.Count - 1)
                    {
                        Console.Write(", ");
                        commaCounter++;
                    }
                    else
                    {
                        Console.WriteLine("]");
                    }
                }
            }
        }

        private static void ProcessRawData(string commandLine, Dictionary<string, Dictionary<string, int>> logs)
        {
            List<string> data = commandLine.Split().ToList();
            string iP = data[0];
            string userId = data[1];
            int time = int.Parse(data[2]);

            if (logs.ContainsKey(userId))
            {
                if (logs[userId].ContainsKey(iP))
                {
                    logs[userId][iP] += time;
                }
                else
                {
                    logs[userId].Add(iP, time);
                }
            }
            else
            {
                logs.Add(userId, new Dictionary<string, int> { { iP, time } });
            }
        }
    }
}