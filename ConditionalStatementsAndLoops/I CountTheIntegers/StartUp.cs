using System;

namespace countTheInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    cnt++;
                }
                catch (Exception)
                {

                    Console.WriteLine(cnt);
                    return;
                }
            }
        }
    }
}