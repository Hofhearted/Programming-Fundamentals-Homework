using System;

namespace Methods
{
    public class StartUp
    {
        public static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number1, number2));
        }
        
        static double RaiseToPower(double number1, double number2)
        {
            double result = Math.Pow(number1, number2);
            return result;
        }
    }
}
