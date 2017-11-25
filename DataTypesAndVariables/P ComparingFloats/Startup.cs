using System;

class ComparingFloats
{
    static void Main()
    {
        float eps = 0.000001f;
        bool result = true;
        
        double firstNumber = Math.Abs(double.Parse(Console.ReadLine()));
        double secondNumber = Math.Abs(double.Parse(Console.ReadLine()));

        if (firstNumber > secondNumber)
        {
            result = firstNumber - secondNumber < eps;
        }
        else
        {
            result = secondNumber - firstNumber < eps;
        }

        Console.WriteLine(result);
    }
}