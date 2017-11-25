using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RestDiscount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int groupsize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (groupsize > 0 && groupsize <= 50)
            {
                double price = 2500;
                var hall = "Small Hall";
                if (package == "Normal")
                {
                    var totalprice = price + 500;
                    var discount = totalprice - totalprice * 0.05;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Gold")
                {
                    var totalprice = price + 750;
                    var discount = totalprice - totalprice * 0.10;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Platinum")
                {
                    var totalprice = price + 1000;
                    var discount = totalprice - totalprice * 0.15;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
            }
            else if (groupsize > 50 && groupsize <= 100)
            {
                double price = 5000;
                var hall = "Terrace";
                if (package == "Normal")
                {
                    var totalprice = price + 500;
                    var discount = totalprice - totalprice * 0.05;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Gold")
                {
                    var totalprice = price + 750;
                    var discount = totalprice - totalprice * 0.10;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Platinum")
                {
                    var totalprice = price + 1000;
                    var discount = totalprice - totalprice * 0.15;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }

            }
            else if (groupsize > 100 && groupsize <= 120)
            {
                double price = 7500;
                var hall = "Great Hall";
                if (package == "Normal")
                {
                    var totalprice = price + 500;
                    var discount = totalprice - totalprice * 0.05;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Gold")
                {
                    var totalprice = price + 750;
                    var discount = totalprice - totalprice * 0.10;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                else if (package == "Platinum")
                {
                    var totalprice = price + 1000;
                    var discount = totalprice - totalprice * 0.15;
                    var priceperperson = discount / groupsize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {priceperperson:F2}$");
                }
                
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
