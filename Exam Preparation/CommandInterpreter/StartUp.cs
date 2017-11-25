using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    public class StartUp
    {
        public static void Main()
        {
            List<string> items = ReadInputItems();

            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "end")
                {
                    break;
                }
                ProcessCommand(items, commandLine);
            }
        }

        private static void ProcessCommand(List<string> items, string commandLine)
        {
            var cmdTokens = commandLine.Split(' ');
            var cmdName = cmdTokens[0];
            switch (cmdName)
            {
                case "reverse":
                    ReverseList(items, cmdTokens, TODO);
                    break;
                case "sort":
                    SortList(items, cmdTokens);
                    break;
                case "rollLeft":
                    RollLeftList(items, cmdTokens);
                    break;
                case "rollRight":
                    RollRightList(items, cmdTokens);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        static void ReverseList(List<string> items, string[] cmdTokens)
        {
            int startIndex = int.Parse(cmdTokens[2]);
            int count = int.Parse(cmdTokens[4]);
            if (isValid(startIndex, count))
            {
                ReverseList(items, startIndex, count);
            }

        }

        private static bool isValid(int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        private static void ReverseList(List<string> items, int startIndex, int count)
        {
            throw new NotImplementedException();
        }

        static void SortList(List<string> items, string[] cmdTokens)
        {

        }
        static void RollLeftList(List<string> items, string[] cmdTokens)
        {

        }
        static void RollRightList(List<string> items, string[] cmdTokens)
        {

        }

        static List<string> ReadInputItems()
        {
            List<string> items = Console.ReadLine().Split(' ').Where(i => i.Length > 0).ToList();
            return items;
        }
    }
}
