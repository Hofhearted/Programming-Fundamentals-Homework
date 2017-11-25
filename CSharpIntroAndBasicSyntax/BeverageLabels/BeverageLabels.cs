using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var energyend = energy * volume * 0.01;
            var sugarend = sugar * volume * 0.01;
            
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyend}kcal, {sugarend}g sugars");
        }
    }
}
