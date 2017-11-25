using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_FastPrimeChecker
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool check = true;
                for (int delio = 2; delio <= Math.Sqrt(number); delio++)
                {
                    if (number % delio == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {check}");

            }
        }
    }
}
