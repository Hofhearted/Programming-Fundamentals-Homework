using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_CakeIngredients
{
    class StartUp
    {
        static void Main(string[] args)
        {
           
            string ingredient = Console.ReadLine();
            int ingredientcount = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredientcount++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredientcount} ingredients.");

        }
    }
}
