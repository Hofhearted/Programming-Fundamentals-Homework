using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_VariableInHexFormat
{
    class Startup
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int value = Convert.ToInt32(hex, 16);
            Console.WriteLine($"{value}");
        }
    }
}
