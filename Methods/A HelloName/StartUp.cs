using System;

namespace A_HelloName
{
    public class StartUp
    {
        public static void Main()
        {
            string Family = Console.ReadLine();
            Name1(Family);
        }
        static void Name1(string Name)
        {
            Console.WriteLine($"Hello, {Name}!");
        }
    }
}
