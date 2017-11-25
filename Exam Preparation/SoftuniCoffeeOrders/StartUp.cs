using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SoftuniCoffeeOrders
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            List<decimal> orders = new List<decimal>();
            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string orderDate = Console.ReadLine();
                DateTime orderdate = DateTime.ParseExact(orderDate, "d/M/yyyy", null);
                int month = DateTime.DaysInMonth(orderdate.Year, orderdate.Month);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                decimal price = (month * capsulesCount) * pricePerCapsule;
                orders.Add(price);
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            decimal end = orders.Sum();
            Console.WriteLine($"Total: ${end:F2}");
        }
    }
}
