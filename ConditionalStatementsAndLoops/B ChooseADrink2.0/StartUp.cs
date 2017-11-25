using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ChooseADrink
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var water = 0.70;
            var coffee = 1.00;
            var beer = 1.70;
            var tea = 1.20;

            if (profession == "Athlete")
            {
                var drink = water;
                var wholeprice = drink * quantity;
                Console.WriteLine($"The {profession} has to pay {wholeprice:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                var drink = coffee;
                var wholeprice = drink * quantity;
                Console.WriteLine($"The {profession} has to pay {wholeprice:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                var drink = beer;
                var wholeprice = drink * quantity;
                Console.WriteLine($"The {profession} has to pay {wholeprice:F2}.");
            }
            else
            {
                var drink = tea;
                var wholeprice = drink * quantity;
                Console.WriteLine($"The {profession} has to pay {wholeprice:F2}.");
            }
        }
    }
}