using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnonymousCache
{
    public class StartUp
    {
        public static void Main()
        {
            string dataSet = Console.ReadLine();
            List<string> list = new List<string>();
            string sth = null;
            while (true)
            {
                string end = "thetinggoesskrra";
                string dataStuffz = Console.ReadLine();
                string pattern = @"([A-Za-z0-9]+)";
                Regex regex = new Regex(pattern);
                MatchCollection dataMatches = regex.Matches(dataStuffz);
                foreach (Match item in dataMatches)
                {
                    sth = item.Groups.ToString();
                    list.Add(sth);
                }
                if (dataStuffz== end)
                {
                    
                    break;
                }
            }
        }
    }
}
