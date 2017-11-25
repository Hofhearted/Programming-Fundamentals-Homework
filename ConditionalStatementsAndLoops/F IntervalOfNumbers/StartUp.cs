using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_IntervalOfNumbers
{
    public class StartUp
    {
        public static void Main()
        {
        
            int none = int.Parse(Console.ReadLine());
            int ntwo = int.Parse(Console.ReadLine());

            if (none < ntwo)
            {
                for (int i = none; i <= ntwo;i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = ntwo; i <= none; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
