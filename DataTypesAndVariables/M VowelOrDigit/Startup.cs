using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char n = char.Parse(Console.ReadLine());
        if (n == 'a' || n == 'e' || n == 'o' || n == 'u' || n == 'i')
        {
            Console.WriteLine("vowel");
        }
        else if (char.IsNumber(n))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}