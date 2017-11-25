using System;
using System.Globalization;

namespace Ze_Lab
{
    public class StartUp
    {
        public static void Main()
        {
            string date = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            date = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDays = 0;
            for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && !(i.Month == 1 && i.Day == 1) && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && 
                    !(i.Month == 5 && i.Day == 6) && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6) && !(i.Month == 9 && i.Day == 22) &&
                    !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25) && !(i.Month == 12 && i.Day == 26) &&
                    i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }
    }
}
