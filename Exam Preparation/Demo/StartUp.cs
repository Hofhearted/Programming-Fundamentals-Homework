using System;
using System.Text;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            TimeSpan timeSpan = TimeSpan.Parse(Console.ReadLine());
            ulong numberOfSteps = ulong.Parse(Console.ReadLine()) % 86400;
            ulong timeInSeconds = ulong.Parse(Console.ReadLine()) % 86400;

            ulong totalSeconds = numberOfSteps * timeInSeconds;
            TimeSpan totalSecondsSpan = TimeSpan.FromSeconds(totalSeconds);
            var totalSpan = timeSpan + totalSecondsSpan;
            Console.WriteLine($"Time Arrival: {totalSpan.Hours:D2}:{totalSpan.Minutes:D2}:{totalSpan.Seconds:D2}");
        }
    }
}
