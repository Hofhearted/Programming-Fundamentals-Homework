using System;
using System.Collections.Generic;
using System.Linq;

namespace K_DragonArmy
{
    internal class DragonArmy
    {
        private static void Main()
        {
            var dragonData = new Dictionary<string, Dictionary<string, int[]>>();
            var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (var i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                ManageInput(command, dragonData);
            }
            PrintResults(dragonData);
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            foreach (var type in dragonData)
            {
                var avDmg = type.Value.Select(x => x.Value[0]).Average();
                var avHp = type.Value.Select(x => x.Value[1]).Average();
                var avArmor = type.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{type.Key}::({avDmg:f2}/{avHp:f2}/{avArmor:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}"
                        , dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
        }

        private static void ManageInput(string command, Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            var details = command.Split();
            var type = details[0];
            var name = details[1];

            var dmg = 45;
            if (details[2] != "null")
            {
                dmg = int.Parse(details[2]);
            }

            var hp = 250;
            if (details[3] != "null")
            {
                hp = int.Parse(details[3]);
            }

            var armor = 10;
            if (details[4] != "null")
            {
                armor = int.Parse(details[4]);
            }

            if (dragonData.ContainsKey(type))
            {
                if (dragonData[type].ContainsKey(name))
                {
                    dragonData[type][name][0] = dmg;
                    dragonData[type][name][1] = hp;
                    dragonData[type][name][2] = armor;
                }
                else
                {
                    dragonData[type].Add(name, new [] { dmg, hp, armor });
                }
            }
            else
            {
                dragonData.Add(type, new Dictionary<string, int[]> { { name, new[] { dmg, hp, armor } } });
            }
        }
    }
}