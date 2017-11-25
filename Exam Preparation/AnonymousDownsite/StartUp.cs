using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AnonymousDownsite
{
    public class StartUp
    {
        public static void Main()
        {
            ulong numberOfWebsitesDown = ulong.Parse(Console.ReadLine());
            ulong securityKey = ulong.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> list = new List<string>();
            ulong securityToken = Pow(securityKey, numberOfWebsitesDown);
            for (ulong i = 0; i < numberOfWebsitesDown; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string siteName = input[0];
                ulong siteVisits = ulong.Parse(input[1]);
                decimal siteCommercialPriceVisit = decimal.Parse(input[2]);
                decimal siteLoss = siteVisits * siteCommercialPriceVisit;
                totalLoss += siteLoss;
                list.Add(siteName);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);  
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
        public static ulong Pow(ulong num, ulong pow)
        {
            ulong answer = 1;
            for (ulong i = 0; i < pow; i++)
            {
                answer *= num;
            }

            return answer;
        }
    }
}
