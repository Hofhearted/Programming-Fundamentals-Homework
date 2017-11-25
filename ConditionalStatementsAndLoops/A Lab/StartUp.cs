using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());
            }
            if (n < 0)
            {
                Console.WriteLine($"The number is: {-n}");
            }
            else
            {
                Console.WriteLine($"The number is: {n}");
            }
        }
    }
}