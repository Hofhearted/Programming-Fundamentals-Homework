using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_TestNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int multiplySum = 0;
            int combinationsCount = 0;

            for (int i = firstDigit; i >=1;  i--)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    multiplySum += (3 * i * j);
                    combinationsCount++;
                    if (multiplySum >= maxSum)
                    {
                        Console.WriteLine($"{combinationsCount} combinations");
                        Console.WriteLine($"Sum: {multiplySum} >= {maxSum}");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinationsCount} combinations");
            Console.WriteLine($"Sum: {multiplySum}");
        }
    }
}
