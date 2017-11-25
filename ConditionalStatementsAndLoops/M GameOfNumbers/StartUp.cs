using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_GameOfNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationsCount = 0;
            for (int i = secondNum; i >= firstNum; i--)
            {
                for (int j = secondNum; j >= firstNum; j--)
                {
                    combinationsCount++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNum}");
        }
    }
}
