using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_BooleanVariable
{
    class Startup
    {
        static void Main(string[] args)
        {
            string stringvalue = Console.ReadLine();
            bool value = Convert.ToBoolean(stringvalue);
            if (value == true)
            {
                Console.WriteLine("Yes");
            }
            else if (value == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
