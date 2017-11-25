using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                int special = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{special} -> {check}");
                sum = 0;
                i = special;
            }

        }
    }
}
