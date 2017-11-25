using System;
using System.Data.SqlTypes;
using System.Numerics;

namespace B_MaxMethod
{
    public class StartUp
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }
        static void GetMax(double a, double b, double c)
        {
            var result = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(result);
        }
    }
}
