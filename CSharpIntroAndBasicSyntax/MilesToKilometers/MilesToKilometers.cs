using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            var convert = mile * 1.60934;
            Console.WriteLine("{0:F2}", convert);
        }
    }
}