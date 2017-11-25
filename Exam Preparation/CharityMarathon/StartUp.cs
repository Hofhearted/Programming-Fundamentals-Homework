using System;

namespace CharityMarathon
{
    public class StartUp
    {
        public static void Main()
        {
            long marathonDayCount = long.Parse(Console.ReadLine());
            long runnerCount = long.Parse(Console.ReadLine());
            long averageLaps = long.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            double moneyPerKM = double.Parse(Console.ReadLine());

            long maximumRunners = trackCapacity * marathonDayCount;
            long totalRunners = Math.Min(maximumRunners, runnerCount);

            long totalMeters = totalRunners * averageLaps * lapLenght;
            long totalKM = totalMeters / 1000;
            double totalMoney = totalKM * moneyPerKM;
            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
