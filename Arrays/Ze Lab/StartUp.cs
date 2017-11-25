using System;

namespace Ze_Lab
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[n] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine($"{arr[n]}");
        }
    }
}
