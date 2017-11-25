using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            int[] firstinput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipElements = firstinput[0];
            int takeElements = firstinput[1];

            string input = Console.ReadLine();

            Regex cameraGroups = new Regex(@"\|<(\w{" + skipElements + @"})(\w{0," + takeElements + @"})");


            MatchCollection solution = cameraGroups.Matches(input);

            List<string> picstaken = new List<string>();
            foreach (Match camera in solution)
            {
                picstaken.Add(camera.Groups[2].Value.ToString());
            }
            Console.WriteLine(string.Join(",", picstaken));
        }
    }
}
