using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currenthp = int.Parse(Console.ReadLine());
            var maxhp = int.Parse(Console.ReadLine());
            var currenteng = int.Parse(Console.ReadLine());
            var maxeng = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new string('|', currenthp));
            Console.Write(new string('.', maxhp - currenthp));
            Console.WriteLine("|");
            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', currenteng));
            Console.Write(new string('.', maxeng - currenteng));
            Console.WriteLine("|");
        }
    }
}
