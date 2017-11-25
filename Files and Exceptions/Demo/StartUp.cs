using System;
using System.IO;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("input-odd-lines.txt");
            for (int i = 1; i < lines.Length; i += 2)
            {
                File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}
