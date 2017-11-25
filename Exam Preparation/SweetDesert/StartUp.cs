using System;

namespace SweetDesert
{
    public class StartUp
    {
        public static void Main()
        {
            decimal ivanchoMoney = decimal.Parse(Console.ReadLine());
            decimal numberOfGuests = decimal.Parse(Console.ReadLine());

            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPricePerKG = decimal.Parse(Console.ReadLine());

            decimal neededSets = (int)numberOfGuests / 6;

            if (numberOfGuests % 6 != 0)
            {
                neededSets++;
            }

            decimal total = neededSets * (2 * bananaPrice) + neededSets * (4 * eggsPrice) +
                        neededSets * ((decimal)0.2 * berriesPricePerKG);

            if (ivanchoMoney >= (decimal) total)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {total:F2}lv.");
            }
            else
            {
                var price = total - ivanchoMoney;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {price:F2}lv more.");
            }

        }
    }
}
